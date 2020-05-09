using System;
using System.IO;
using JetBrains.Annotations;
using Nuke.Common;
using Nuke.Common.CI;
using Nuke.Common.CI.AzurePipelines;
using Nuke.Common.Execution;
using Nuke.Common.Git;
using Nuke.Common.IO;
using Nuke.Common.ProjectModel;
using Nuke.Common.Tooling;
using Nuke.Common.Tools.DotNet;
using Nuke.Common.Tools.GitVersion;
using Nuke.Common.Utilities;
using Nuke.Common.Utilities.Collections;
using static Nuke.Common.ChangeLog.ChangelogTasks;
using static Nuke.Common.EnvironmentInfo;
using static Nuke.Common.IO.FileSystemTasks;
using static Nuke.Common.IO.HttpTasks;
using static Nuke.Common.IO.PathConstruction;
using static Nuke.Common.Tools.DotNet.DotNetTasks;
using static Nuke.Common.Tools.Git.GitTasks;

[CheckBuildProjectConfigurations]
[UnsetVisualStudioEnvironmentVariables]
[AzurePipelines(
    suffix: null,
    AzurePipelinesImage.WindowsLatest,
    InvokedTargets = new[] { nameof(PackNuget), nameof(InstallTool), nameof(PublishNuget) },
    NonEntryTargets = new[] { nameof(Restore), nameof(DownloadAntlrTool), nameof(BuildSolution) },
    ExcludedTargets = new[] { nameof(Clean), nameof(Release), nameof(Changelog) },
    AutoGenerate = false // todo download artifacts not working!
)]
class Build : NukeBuild
{
    /// Support plugins are available for:
    ///   - JetBrains ReSharper        https://nuke.build/resharper
    ///   - JetBrains Rider            https://nuke.build/rider
    ///   - Microsoft VisualStudio     https://nuke.build/visualstudio
    ///   - Microsoft VSCode           https://nuke.build/vscode
    public static int Main() => Execute<Build>(x => x.BuildSolution);

    [Parameter("Configuration to build - Default is 'Debug' (local) or 'Release' (server)")]
    readonly Configuration Configuration = IsLocalBuild ? Configuration.Debug : Configuration.Release;

    [Parameter("The ANTLR Java tool version.")]
    readonly string AntlrVersion = "4.8";

    [Parameter("NuGet Api Key")]
    readonly string NugetApiKey;

    [Parameter("NuGet Source for Packages")]
    readonly string NugetSource = "https://api.nuget.org/v3/index.json";

    [Parameter("API endpoint to push NuGet source packages")]
    readonly string SymbolSource = "https://nuget.smbsrc.net/";

    [Solution]
    readonly Solution Solution;

    [GitRepository]
    readonly GitRepository GitRepository;

    [GitVersion(Framework = "netcoreapp3.1", UpdateBuildNumber = true)]
    readonly GitVersion GitVersion;

    [CI]
    readonly AzurePipelines AzurePipelines;

    AbsolutePath SourceDirectory => RootDirectory / "src";
    AbsolutePath TestsDirectory => RootDirectory / "tests";
    AbsolutePath ArtifactsDirectory => RootDirectory / ".artifacts";

    AbsolutePath NugetOutputPath => ArtifactsDirectory / "nupkg";

    string ChangelogFile => RootDirectory / "CHANGELOG.md";

    const string MasterBranch = "master";
    const string DevelopBranch = "develop";
    const string ReleaseBranchPrefix = "release";
    const string HotfixBranchPrefix = "hotfix";

    bool DoPublishNuget => GitRepository.IsOnMasterBranch()
                           ||GitRepository.IsOnHotfixBranch()
                           || GitRepository.IsOnReleaseBranch();

    Project ToolProject => Solution.GetProject("Antlr4.CodeGenerator.Tool");
    string TooId => "Antlr4CodeGenerator.Tool";

    Target Clean => _ => _
        .Before(Restore)
        .Executes(() =>
        {

            SourceDirectory.GlobDirectories("**/bin", "**/obj").ForEach(DeleteDirectory);
            TestsDirectory.GlobDirectories("**/bin", "**/obj").ForEach(DeleteDirectory);
            EnsureCleanDirectory(ArtifactsDirectory);
        });

    Target DownloadAntlrTool => _ => _
        .Executes(() =>
        {
            var downloadLink = $"https://www.antlr.org/download/antlr-{AntlrVersion}-complete.jar";
            var artifactFileName = Path.Combine(ToolProject.Directory, "tools", $"antlr-{AntlrVersion}-complete.jar");
            if (File.Exists(artifactFileName))
            {
                return;
            }

            HttpDownloadFileAsync(downloadLink, artifactFileName).GetAwaiter().GetResult();
        });

    Target Restore => _ => _
        .DependsOn(Clean, DownloadAntlrTool)
        .Executes(() =>
        {
            DotNetRestore(s => s
                .SetProjectFile(Solution));
        });


    Target BuildSolution => _ => _
        .DependsOn(Restore)
        .Executes(() =>
        {
            var projectsToBuild = new[]
            {
                ToolProject,
            };
            DotNetBuild(_ => _
                .SetProjectFile(Solution)
                .SetConfiguration(Configuration)
                .SetAssemblyVersion(GitVersion.AssemblySemVer)
                .SetFileVersion(GitVersion.AssemblySemFileVer)
                .SetInformationalVersion(GitVersion.InformationalVersion)
                .EnableNoRestore()
                .CombineWith(projectsToBuild, (_, p) => _
                    .SetProjectFile(p))
            );
        });

    Target Changelog => _ => _
        .Unlisted()
        .OnlyWhenStatic(() => GitRepository.IsOnReleaseBranch() || GitRepository.IsOnHotfixBranch())
        .Executes(() =>
        {
            FinalizeChangelog(ChangelogFile, GitVersion.MajorMinorPatch, GitRepository);
            Logger.Info("Please review CHANGELOG.md and press any key to continue...");
            Console.ReadKey();

            Git($"add {ChangelogFile}");
            Git($"commit -m \"Finalize {Path.GetFileName(ChangelogFile)} for {GitVersion.MajorMinorPatch}\"");
        });

    [UsedImplicitly]
    Target Release => _ => _
        .DependsOn(Changelog)
        .Requires(() => !GitRepository.IsOnReleaseBranch() || GitHasCleanWorkingCopy())
        .Executes(() =>
        {
            if (!GitRepository.IsOnReleaseBranch())
            {
                var hasCleanWorkingCopy = GitHasCleanWorkingCopy();
                ControlFlow.Assert(hasCleanWorkingCopy, "Working directory has changes.");
                Git($"checkout -b {ReleaseBranchPrefix}/{GitVersion.MajorMinorPatch} {DevelopBranch}");
            }
            else
                FinishReleaseOrHotfix();
        });

    Target PackNuget => _ => _
        .Produces(NugetOutputPath)
        .DependsOn(BuildSolution)
        .Executes(() =>
        {
            var projectsToPack = new[]
            {
                ToolProject,
            };
            DotNetPack(s => s
                .SetOutputDirectory(NugetOutputPath)
                .SetConfiguration(Configuration)
                .SetVersion(GitVersion.NuGetVersionV2)
                .EnableNoBuild()
                .EnableIncludeSymbols()
                .SetSymbolPackageFormat(DotNetSymbolPackageFormat.snupkg)
                .CombineWith(projectsToPack, (_, p) => _
                    .SetProject(p))
            );
        });

    Target InstallTool => _ => _
        .DependsOn(PackNuget)
        .Consumes(PackNuget)
        .Executes(() =>
        {
            ControlFlow.SuppressErrors(() => DotNet($"tool uninstall -g {TooId}"));
            DotNet($"tool install -g {TooId} --add-source {NugetOutputPath} --version {GitVersion.NuGetVersionV2}");
        });

    Target PublishNuget => _ => _
        .DependsOn(InstallTool)
        .Consumes(PackNuget)
        .OnlyWhenDynamic(() => DoPublishNuget)
        .Requires(() => GitHasCleanWorkingCopy())
        .Requires(() => Configuration.Equals(Configuration.Release))
        .Executes(() =>
        {
            NugetApiKey.NotEmpty();
            DotNetNuGetPush(_ => _
                    .SetSource(NugetSource)
                    .SetApiKey(NugetApiKey)
                    .SetSymbolSource(SymbolSource)
                    .CombineWith(
                        NugetOutputPath.GlobFiles("*.nupkg").NotEmpty(), (_, v) => _
                            .SetTargetPath(v)),
                degreeOfParallelism: 5,
                completeOnFailure: true);
        });

    void FinishReleaseOrHotfix()
    {
        Git($"checkout {MasterBranch}");
        Git($"merge --no-ff --no-edit {GitRepository.Branch}");
        Git($"tag {GitVersion.MajorMinorPatch}");

        Git($"checkout {DevelopBranch}");
        Git($"merge --no-ff --no-edit {GitRepository.Branch}");

        Git($"branch -D {GitRepository.Branch}");

        Git($"push origin {MasterBranch} {DevelopBranch} {GitVersion.MajorMinorPatch}");
    }
}
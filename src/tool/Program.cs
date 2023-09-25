using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antlr4.CodeGenerator.Tool
{
    internal class Program
    {
        private const string ExecutableName = "java";

        private static readonly string AntlrToolPath =
            Path.Combine(Path.GetDirectoryName(typeof(Program).Assembly.Location) ?? ".", "tools", "antlr-4.13.1-complete.jar");

        private static readonly string[] JavaArgs = { "-jar", AntlrToolPath };

        private static async Task<int> Main(string[] args)
        {
            Console.WriteLine($"Executing: {ExecutableName} {string.Join(" ", JavaArgs.Concat(args))}");
            var startInfo = new ProcessStartInfo
            {
                UseShellExecute = false,
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden,
                FileName = ExecutableName,
                RedirectStandardError = true,
                RedirectStandardOutput = true,
                StandardErrorEncoding = Encoding.UTF8,
                StandardOutputEncoding = Encoding.UTF8,
            };
            foreach (var arg in JavaArgs.Concat(args))
            {
                startInfo.ArgumentList.Add(arg);
            }

            using var process = new Process
            {
                StartInfo = startInfo
            };
            process.Start();

            var error = await process.StandardError.ReadToEndAsync();
            if (!string.IsNullOrEmpty(error))
            {
               await Console.Error.WriteLineAsync($"Error: {error}");
            }

            var info = await process.StandardOutput.ReadToEndAsync();
            if (!string.IsNullOrEmpty(info))
            {
                Console.WriteLine($"Info: {info}");
            }

            await process.WaitForExitAsync();
            return process.ExitCode;
        }
    }
}
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace Antlr4.CodeGenerator.Tool
{
    internal class Program
    {
        private const string ExecutableName = "java";

        private static readonly string AntlrToolPath =
            Path.Combine(Path.GetDirectoryName(typeof(Program).Assembly.Location) ?? ".", "tools", "antlr-4.8-complete.jar");

        private static readonly string[] JavaArgs = { "-jar", AntlrToolPath };

        private static int Main(string[] args)
        {
            Console.WriteLine($"Executing: {ExecutableName} {string.Join(" ", JavaArgs.Concat(args))}");
            using var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    FileName = ExecutableName,
                    Arguments = string.Join(" ", JavaArgs.Concat(args)),
                    RedirectStandardError = true,
                    RedirectStandardOutput = true,
                    StandardErrorEncoding = Encoding.UTF8,
                    StandardOutputEncoding = Encoding.UTF8,
                }
            };
            process.Start();

            var error = process.StandardError.ReadToEnd();
            if (!string.IsNullOrEmpty(error))
            {
                Console.Error.WriteLine($"Error: {error}");
            }

            var info = process.StandardOutput.ReadToEnd();
            if (!string.IsNullOrEmpty(info))
            {
                Console.WriteLine($"Info: {info}");
            }

            process.WaitForExit();
            return process.ExitCode;
        }
    }
}
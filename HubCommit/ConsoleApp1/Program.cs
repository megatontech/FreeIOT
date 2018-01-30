using System;
using System.Diagnostics;

namespace ConsoleApp1
{
    internal class Program
    {
        public static bool addFiles()
        {
            bool isSuccess = true;
            try
            {
                Process p = new Process();
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.WorkingDirectory = @"C:\Users\yuri\OneDrive\megatontech.github.io.git";
                p.StartInfo.CreateNoWindow = false;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardInput = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardError = true;
                p.Start();
                p.StandardInput.WriteLine("git add .");
                p.StandardInput.AutoFlush = true;
                p.WaitForExit(9000);
            }
            catch (Exception e) { isSuccess = false; }
            return isSuccess;
        }

        public static bool commitFiles()
        {
            bool isSuccess = true;
            try
            {
                Process p = new Process();
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.WorkingDirectory = @"C:\Users\yuri\OneDrive\megatontech.github.io.git";
                p.StartInfo.CreateNoWindow = false;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardInput = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardError = true;
                p.Start();
                p.StandardInput.WriteLine("git commit -m \"client commit\"");
                p.StandardInput.AutoFlush = true;
                p.WaitForExit(9000);
            }
            catch (Exception e) { isSuccess = false; }
            return isSuccess;
        }
        public static bool pushFiles()
        {
            bool isSuccess = true;
            try
            {
                Process p = new Process();
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.WorkingDirectory = @"C:\Users\yuri\OneDrive\megatontech.github.io.git";
                p.StartInfo.CreateNoWindow = false;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardInput = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardError = true;
                p.Start();
                p.StandardInput.WriteLine("git push");
                ///p.StandardInput.WriteLine("techme@live.cn");
                ///p.StandardInput.WriteLine("Yu153037");
                p.WaitForExit(9000);
            }
            catch (Exception e) { isSuccess = false; }
            return isSuccess;
        }

        private static void Main(string[] args)
        {
            addFiles();
            commitFiles();
            pushFiles();
        }
    }
}
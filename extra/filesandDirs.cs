using System;
using System.IO;

namespace ConsoleApp1
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Write(">> ");
                string str = Console.ReadLine().Trim();
                if (string.IsNullOrWhiteSpace(str))
                {
                    continue;
                }

                if (str.ToLower() == "exit")
                {
                    break;
                }

                dir(str);
            }
        }

        private static void dir(string str)
        {
            var whiteSpace = str.IndexOf(' ');
            if (whiteSpace == -1)
            {
                Console.WriteLine("Invalid command.");
                return;
            }

            var command = str.Substring(0, whiteSpace);
            var path = str.Substring(whiteSpace + 1).Trim();

            if (command == "list")
            {
                if (Directory.Exists(path))
                {
                    foreach (var entry in Directory.GetDirectories(path))
                        Console.WriteLine($"\t[Dir] {entry}");
                    foreach (var entry in Directory.GetFiles(path))
                        Console.WriteLine($"\t[File] {entry}");
                }
                else
                {
                    Console.WriteLine("Directory does not exist.");
                }
            }
            else if (command == "info")
            {
                if (Directory.Exists(path))
                {
                    var info = new DirectoryInfo(path);
                    Console.WriteLine("Type: Directory");
                    Console.WriteLine($"Created At: {info.CreationTime}");
                    Console.WriteLine($"Last Modified At: {info.LastWriteTime}");
                }
                else if (File.Exists(path))
                {
                    var info = new FileInfo(path);
                    Console.WriteLine("Type: File");
                    Console.WriteLine($"Created At: {info.CreationTime}");
                    Console.WriteLine($"Last Modified At: {info.LastWriteTime}");
                    Console.WriteLine($"Size in Bytes: {info.Length}");
                }
                else
                {
                    Console.WriteLine("Path does not exist.");
                }
            }
            else
            {
                Console.WriteLine("Unknown command.");
            }
        }
    }
}

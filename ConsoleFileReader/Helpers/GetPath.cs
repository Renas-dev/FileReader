using System;
using System.IO;

namespace ConsoleFileReaders.Helpers
{
    class PathValidator
    {
        public static string GetPath()
        {
            while (true)
            {
                Console.WriteLine("Hello, please provide the path of the file:");
                string? pathLocation = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(pathLocation))
                {
                    Console.WriteLine("Invalid input. Please enter a non-empty file path:");
                    continue;
                }
                if (!File.Exists(pathLocation))
                {
                    Console.WriteLine("File not found. Please enter a valid existing file path.");
                    continue;
                }
                Console.WriteLine($"The given path location exists: {pathLocation}");
                return pathLocation;
            }
        }
    }

    class ReadFile
    {
        public static void FileReader(string path)
        {
            string contents = File.ReadAllText(path);
            Console.WriteLine(contents);
        }
    }
    class LineCounter
    {
        public static void DisplayFileLines(string path)
        {
            var lineCount = 0;
            using (var reader = File.OpenText(path))
            {
                while (reader.ReadLine() != null)
                {
                    lineCount++;
                }
            }
            Console.WriteLine($"This file has: {lineCount} Lines");
        }
    }
}
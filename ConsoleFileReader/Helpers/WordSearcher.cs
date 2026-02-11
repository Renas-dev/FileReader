using System;
using System.IO;

namespace ConsoleFileReaders.Helpers
{
    class WordSearcher
    {
        public static void FindMatchingLines(string path)
        {   
            var lineCount = 0;
            var lineNumber = 0;
            Console.WriteLine("Give a word to lookup");
            string toSearch = Console.ReadLine()?.Trim() ?? string.Empty;
            if (string.IsNullOrWhiteSpace(toSearch))
            {
                Console.WriteLine("Please type a proper word in");
                return;
            }
            foreach (string line in File.ReadLines(path))
            {
                lineNumber ++;
                if (line.Contains(toSearch, StringComparison.OrdinalIgnoreCase))
                {
                    lineCount ++;
                Console.WriteLine($"Line {lineNumber}: {line}");
                }
            }
            if (lineCount == 0)
            {
                Console.WriteLine($"word {toSearch} is not present in file");
            }
            Console.WriteLine($"Total amount of times found: {lineCount}");
        }
    }
}

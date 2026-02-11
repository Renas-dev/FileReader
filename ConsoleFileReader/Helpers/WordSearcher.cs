using System;
using System.IO;

namespace ConsoleFileReaders.Helpers
{
    class WordSearcher
    {
        public static void FindMatchingLines(string path)
        {
            int matchCount = 0;
            int lineNumber = 0;
            Console.WriteLine("Enter a word to search for:");
            string toSearch = Console.ReadLine()?.Trim() ?? string.Empty;
            if (string.IsNullOrWhiteSpace(toSearch))
            {
                Console.WriteLine("Search term cannot be empty.");
                return;
            }
            foreach (string line in File.ReadLines(path))
            {
                lineNumber++;
                if (line.Contains(toSearch, StringComparison.OrdinalIgnoreCase))
                {
                    matchCount++;
                    Console.WriteLine($"Line {lineNumber}: {line}");
                }
            }
            if (matchCount == 0)
            {
                Console.WriteLine($"The word '{toSearch}' is not present in the file.");
            }
            Console.WriteLine($"Total matches found: {matchCount}");
        }
    }
}

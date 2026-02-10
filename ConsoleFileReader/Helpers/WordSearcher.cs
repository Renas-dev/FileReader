using System;
using System.IO;

namespace ConsoleFileReaders.Helpers
{
    class WordSearcher
    {
        public static void FindMatchingLines(string path)
        {
            Console.WriteLine("Give a word to lookup");
            string toSearch = Console.ReadLine()?.Trim() ?? string.Empty;
            bool foundAny = false;
            if (string.IsNullOrWhiteSpace(toSearch))
            {
                Console.WriteLine("Please type a proper word in");
                return;
            }
            foreach (string line in File.ReadLines(path))
            {
                if (line.Contains(toSearch, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(line);
                    foundAny = true;
                }
            }
            if (foundAny == false)
            {
                Console.WriteLine($"word {toSearch} is not present in file");
            }
        }
    }
}

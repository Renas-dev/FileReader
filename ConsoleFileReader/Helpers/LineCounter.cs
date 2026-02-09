using System;
using System.IO;

namespace ConsoleFileReaders.Helpers
{
    class LineCounter
    {
        public static void CountLines(string path)
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
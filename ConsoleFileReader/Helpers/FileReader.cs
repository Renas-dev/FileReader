using System;
using System.IO;

namespace ConsoleFileReaders.Helpers
{
        class ReadFile
    {
        public static void ReadContents(string path)
        {
            string contents = File.ReadAllText(path);
            Console.WriteLine(contents);
        }
    }
}
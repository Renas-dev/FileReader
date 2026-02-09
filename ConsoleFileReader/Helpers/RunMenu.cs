using System;
using System.IO;
using ConsoleFileReaders.Helpers;

namespace ConsoleFileReaders.Helpers
{
    class InitializeMenu
    {
       public static void StartMenu()
        {
            string path = PathValidator.GetPath();
            Console.WriteLine("Please choose 1 to print all the text, or 2 to count all the text");
            if (File.Exists(path))
            {
                string? input = Console.ReadLine();
                if (input == "1")
                {
                    ReadFile.ReadContents(path);
                }
                else if (input == "2")
                {
                    LineCounter.CountLines(path);
                }
            }
        }
    }
}
using System;
using System.IO;

namespace ConsoleFileReaders.Helpers
{
    class InitializeMenu
    {
        public static void PrintMenu()
        {
            Console.WriteLine("Please choose what u want to do:");
            Console.WriteLine("Type 1 to print the entire document text out");
            Console.WriteLine("Type 2 to Count all the lines present in the document");
            Console.WriteLine("Type 3 to search if a word is present in the document");
            Console.WriteLine("type q to quit the program.");
        }
        public static void StartMenu()
        {
            string path = PathValidator.GetPath();

            while (true)
            {
                PrintMenu();
                string? input = Console.ReadLine();
                input = input?.Trim().ToLower();
                if (input == "1")
                {
                    ReadFile.ReadContents(path);

                }
                else if (input == "2")
                {
                    LineCounter.CountLines(path);

                }
                else if (input == "3")
                {
                    WordSearcher.FindMatchingLines(path);
                }
                else if (input == "q")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter 1, 2, or q.");

                }
            }
        }
    }
}
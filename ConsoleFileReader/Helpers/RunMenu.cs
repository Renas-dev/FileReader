using System;
using System.IO;

namespace ConsoleFileReaders.Helpers
{
    class InitializeMenu
    {
        public static void PrintMenu()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("[1] Print document");
            Console.WriteLine("[2] Count lines");
            Console.WriteLine("[3] Search for a word");
            Console.WriteLine("[Q] Quit");
            Console.WriteLine();
        }
        public static void StartMenu()
        {
            string path = PathValidator.GetPath();

            while (true)
            {
                Console.WriteLine();
                PrintMenu();
                string? input = Console.ReadLine();
                input = input?.Trim().ToLower();
                if (input == "1")
                {
                    ReadFile.ReadContents(path);

                    System.Threading.Thread.Sleep(5000);

                }
                else if (input == "2")
                {
                    LineCounter.CountLines(path);
                    System.Threading.Thread.Sleep(5000);

                }
                else if (input == "3")
                {
                    WordSearcher.FindMatchingLines(path);
                    System.Threading.Thread.Sleep(5000);
                }
                else if (input == "q")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option. Please enter 1, 2, 3, or Q.");
                }
            }
        }
    }
}
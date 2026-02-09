using System;
using System.IO;

namespace ConsoleFileReaders.Helpers
{
    class InitializeMenu
    {
        public static void PrintMenu()
        {
            Console.WriteLine("Please choose 1 to print all the text, or 2 to count all the lines or q to exit");
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
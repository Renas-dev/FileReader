using System;
using System.IO;
using ConsoleFileReaders.Helpers;

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
            PrintMenu();
            while (true)
            {
                string? input = Console.ReadLine();
                if (input == "1")
                {
                    ReadFile.ReadContents(path);
                    PrintMenu();
                }
                else if (input == "2")
                {
                    LineCounter.CountLines(path);
                    PrintMenu();
                }
                else if (input == "q")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter 1, 2, or q.");
                    PrintMenu();
                }
            }
        }
    }
}
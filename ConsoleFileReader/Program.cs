using System;
using System.IO;

class Program
{
    static void Main()
    {
        string? path;
        while (true)
        {
            Console.WriteLine("Hello, please provide the path of the file:");
            string? pathLocation = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(pathLocation))
            {
                Console.WriteLine("Invalid input. Please enter a non-empty file path:");
                continue;
            }
            if (!File.Exists(pathLocation))
            {
                Console.WriteLine("File not found. Please enter a valid existing file path.");
                continue;
            }
            path = pathLocation;
            Console.WriteLine($"The given path location exists: {path}");
            break;
        }
        Console.WriteLine(path);
        string contents = File.ReadAllText(path);
        Console.WriteLine(contents);
    }
}
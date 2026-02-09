using System;
using System.IO;
using ConsoleFileReaders.Helpers;

class Program
{
    static void Main()
    {
        string path = PathValidator.GetPath();
        ReadFile.ReadContents(path);
        LineCounter.CountLines(path);
    }
}
///Users/renas/Desktop/Ebri ProjectBeheer/meower.txt
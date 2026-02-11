using System;
using System.IO;

namespace ConsoleFileReaders.Helpers
{
    class FileMetadataReader
    {
        public static void PrintMetadata(string path)
        {
            FileInfo file = new FileInfo(path);
            Console.WriteLine($"File name: {file.Name}");
            Console.WriteLine($"Full path: {file.FullName}");
            Console.WriteLine($"Directory: {file.DirectoryName}");
            Console.WriteLine($"File size (bytes): {file.Length}");
            Console.WriteLine($"Created on: {file.CreationTime}");
            Console.WriteLine($"Last modified: {file.LastWriteTime}");
            Console.WriteLine($"Last accessed: {file.LastAccessTime}");
            Console.WriteLine($"Extension: {file.Extension}");
            Console.WriteLine($"Attributes: {file.Attributes}");

        }
    }
}
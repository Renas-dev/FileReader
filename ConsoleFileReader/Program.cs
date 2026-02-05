Console.WriteLine("Hello, please provide the path of the file:");

string? pathLocation = Console.ReadLine();

while (string.IsNullOrWhiteSpace(pathLocation))
{
    Console.WriteLine("Invalid input. Please enter a non-empty file path:");
    pathLocation = Console.ReadLine();
}

Console.WriteLine($"The given path location is: {pathLocation}");

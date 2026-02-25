Console.WriteLine("== Project 202: String Manipulator ==");
Console.Write("Enter a Word or a Senetence: ");

string input = Console.ReadLine();

Console.WriteLine("-- Manipulations --");
System.Console.WriteLine($"Uppercase: {input.ToUpper()}");
System.Console.WriteLine($"Lowercase: {input.ToLower()}");
System.Console.WriteLine($"Total Characters: {input.Length}");

int vowelCount = 0;

string vowels = "aeiouAEIOU";

foreach ( char letter in input)
{
    if (vowels.Contains(letter))
    {
        vowelCount++;
    }
}
Console.WriteLine($"Total Vowels: {vowelCount}");
Console.WriteLine("Press any key to exit...");
Console.ReadKey();
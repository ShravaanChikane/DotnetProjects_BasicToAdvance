Random random = new Random();
int SecretNumber = random.Next(1, 101);
int UserGuess = 0;
int Attempts = 0;

Console.WriteLine("== Project 203: Number Guesser ==");
Console.WriteLine("I'm thinking of a number between 1 and 100. Can you guess it?");

while (UserGuess != SecretNumber)
{
    Console.Write("Enter Your Guess: ");
    string input = Console.ReadLine();
    if (int.TryParse(input, out UserGuess))
    {
        Console.WriteLine("Please enter a valid Whole Number!");
        continue;
    }
    Attempts++;
    if (UserGuess < SecretNumber)
    {
        Console.WriteLine("Too low! Try again.");
    }
    else if (UserGuess > SecretNumber)
    {
        Console.WriteLine("Too high! Try again.");
    }
    else
    {
        Console.WriteLine($"🎉 Correct! You found it in {Attempts} attempts.");
    }
}

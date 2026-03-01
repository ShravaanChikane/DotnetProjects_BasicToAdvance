System.Console.WriteLine(   "== Project 204: Hangman =="    );
string secretWord = "coders";
int lives = 5;

char[] guessedLetters = new char[secretWord.Length];
for (int i = 0; i < secretWord.Length ; i++){
    guessedLetters[i] = '_';
}
bool isGameOver = false;
while (isGameOver == false)
{
    System.Console.WriteLine( $"\nWord: {new string(guessedLetters)}" );
    System.Console.WriteLine( $"Lives: {lives}" );
    System.Console.Write("Guess a letter: ");
    string input = Console.ReadLine().ToLower();
    char guessedLetter = input[0]; 
    bool foundLetter = false; 

    for (int i = 0; i < secretWord.Length; i++)
    {
        if (secretWord[i] == guessedLetter)
        {
            guessedWord[i] = guessedLetter; 
            foundLetter = true; 
        }
    }
    if (foundLetter == false)
    {
        lives = lives - 1; 
        Console.WriteLine("Wrong guess!");
    }
    if (!new string(guessedWord).Contains('_')) 
    {
        Console.WriteLine($"\n🎉 You Win! The word was {secretWord}.");
        isGameOver = true; 
    }
    else if (lives == 0)
    {
        Console.WriteLine($"\n💀 Game Over! The word was {secretWord}.");
        isGameOver = true; 
    }
}

Console.WriteLine("Press any key to exit...");
Console.ReadKey();
Console.WriteLine("=== Project 205: Tic-Tac-Toe ===");

// Syntax: A 2D Array uses a comma [,] in the brackets.
// We initialize it with 3 rows and 3 columns.
char[,] board = {
    {'1', '2', '3'},
    {'4', '5', '6'},
    {'7', '8', '9'}
};

int turns = 0;
char currentPlayer = 'X';
bool isGameOver = false;

while (!isGameOver && turns < 9)
{
    Console.Clear(); // Clears the console to redraw the board cleanly
    Console.WriteLine("Tic-Tac-Toe\n");

    // 1. Draw the board using Nested Loops
    for (int row = 0; row < 3; row++)
    {
        for (int col = 0; col < 3; col++)
        {
            Console.Write($" {board[row, col]} ");
            if (col < 2) Console.Write("|"); // Print column separators
        }
        Console.WriteLine();
        if (row < 2) Console.WriteLine("---+---+---"); // Print row separators
    }

    // 2. Get User Input
    Console.Write($"\nPlayer {currentPlayer}, choose a square (1-9): ");
    string input = Console.ReadLine();
    
    // 3. Math Magic: Convert 1-9 into grid coordinates
    if (int.TryParse(input, out int choice) && choice >= 1 && choice <= 9)
    {
        // Example: If choice is 5. (5-1)/3 = 1 (Row 1). (5-1)%3 = 1 (Col 1). 
        int row = (choice - 1) / 3;
        int col = (choice - 1) % 3;

        // Check if the spot is already taken
        if (board[row, col] != 'X' && board[row, col] != 'O')
        {
            board[row, col] = currentPlayer; // Place the X or O
            turns++;

            // 4. Very basic win check (Checking just the first row as an example)
            // To make this fully functional, you would check all rows, cols, and diagonals
            if ((board[0, 0] == currentPlayer && board[0, 1] == currentPlayer && board[0, 2] == currentPlayer) || 
                (board[1, 0] == currentPlayer && board[1, 1] == currentPlayer && board[1, 2] == currentPlayer) ||
                (board[2, 0] == currentPlayer && board[2, 1] == currentPlayer && board[2, 2] == currentPlayer))
            {
                Console.Clear();
                Console.WriteLine($"\n🎉 Player {currentPlayer} WINS!");
                isGameOver = true;
            }
            else
            {
                // Switch players: If it's X, make it O. Otherwise, make it X.
                currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
            }
        }
        else
        {
            Console.WriteLine("That square is already taken! Press Enter to try again.");
            Console.ReadLine();
        }
    }
}

if (!isGameOver) Console.WriteLine("\nIt's a Draw!");
Console.WriteLine("Press any key to exit...");
Console.ReadKey();
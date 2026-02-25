Console.WriteLine("Welcome to the Calculator!");
Console.WriteLine("---------------------------");
Console.Write("Enter the first number: ");
string FirstInput = Console.ReadLine();
double num1 = Convert.ToDouble(FirstInput);
Console.Write("Enter the second number: ");
string SecondInput = Console.ReadLine();
double num2 = Convert.ToDouble(SecondInput);

Console.WriteLine("Select an operation:");
Console.WriteLine("1. Addition (+)");
Console.WriteLine("2. Subtraction (-)");
Console.WriteLine("3. Multiplication (*)");
Console.WriteLine("4. Division (/)");
Console.Write("Your Choice");
string choice = Console.ReadLine();

double result = 0;

switch (choice)
{
    case "1":
        result = num1 + num2;
        Console.WriteLine($"Result: {num1} + {num2} = {result}");
        break;
    case "2":
        result = num1 - num2;
        Console.WriteLine($"Result: {num1} - {num2} = {result}");
        break;
    case "3":
        result = num1 * num2;
        Console.WriteLine($"Result: {num1} * {num2} = {result}");
        break;
    case "4":
        if (num2 != 0)
        {
            result = num1 / num2;
            Console.WriteLine($"Result: {num1} / {num2} = {result}");
        }
        else
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
        break;
    default:
        Console.WriteLine("Invalid choice. Please select a valid operation.");
        break;
}

Console.WriteLine("Press any key to exit...");
Console.ReadKey();
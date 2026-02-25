Project 201: Console Calculator

Overview
A fundamental C# Console application that performs basic arithmetic operations. This project focuses on the core mechanics of user input, data types, and basic control flow.

Concepts Learned
1. Console I/O: Using `Console.WriteLine` and `Console.ReadLine`.
2. Type Conversion: Converting string inputs into `double` using `Convert.ToDouble`.
3. Control Flow: Implementing a `switch` statement to handle different logic branches.
4. Error Prevention: Basic validation to prevent division by zero.

Code Explanation
The program follows a linear execution path:
1. Input: It captures two numbers as strings and immediately casts them to `double` to allow for decimal calculations.
2. Logic: A `switch` block evaluates the operator string (+, -, *, /). 
3. Execution: Depending on the match, the corresponding math operation is performed. If the user tries to divide by zero, an `if` statement intercepts the operation to prevent a runtime crash.

How to Run
1. Navigate to the project folder: `cd 201_Calculator`
2. Run the command: `dotnet run`

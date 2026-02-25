Project 202: String Manipulator

Overview
A text processing tool designed to explore the power and nuances of the `System.String` class in C#. This project demonstrates how to transform, analyze, and iterate through text data.

Concepts Learned
1. String Methods: Utilizing `.ToUpper()`, `.ToLower()`, and `.Replace()`.
2. String Properties: Accessing metadata like `.Length`.
3. Immutability: Understanding that string methods return *new* strings rather than modifying the original.
4. Iteration: Using a `foreach` loop to inspect individual `char` elements within a string.



Code Explanation
1. Transformation: We use built-in methods to change the casing of the entire string.
2. Chaining: The "Hacker Speak" feature demonstrates **method chaining**, where `.Replace()` is called multiple times in a single line.
3. Analysis: We initialize a counter (`vowelCount`) and use a `foreach` loop to check if each character in the input exists within a predefined string of vowels (`aeiou`) using the `.Contains()` method.

How to Run
1. Navigate to the project folder: `cd 202_StringManipulator`
2. Run the command: `dotnet run`

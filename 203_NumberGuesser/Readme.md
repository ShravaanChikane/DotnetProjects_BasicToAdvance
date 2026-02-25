Project 203: Number Guesser

Overview
An interactive game that challenges the user to guess a randomly generated number. This project introduces logic for repetition and randomness.

Concepts Learned
1. Randomization:** Using `System.Random`.
2. Iteration:** Mastering `while` loops for continuous execution.
3. Data Validation:** Using `int.TryParse` to prevent runtime crashes from bad user input.
4. State Management:** Tracking variables (attempts) across multiple loop cycles.

Interview Questions
Q1: Why use `int.TryParse` instead of `int.Parse`?
A: `int.Parse` throws an exception (crashes) if the input is not a number. `int.TryParse` returns a boolean (true/false) and outputs the number safely, making the code more robust and "defensive."

Q2: What is the difference between a `while` loop and a `do-while` loop?
A: A `while` loop checks the condition *before* running the code (it might never run). A `do-while` loop runs the code once *before* checking the condition, ensuring the block executes at least once.

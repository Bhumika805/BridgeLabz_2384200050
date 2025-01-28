using System;

namespace PracticeProblem2
{
        class RecursiveSum
        {
            public void NaturalNumber()
            {
                Console.Write("Enter a natural number: ");
                string input = Console.ReadLine();

                if (IsNaturalNumber(input))
                {
                    int n = Convert.ToInt32(input);

                    // Step 2: Calculate the sum using recursion
                    int recursiveSum = SumUsingRecursion(n);

                    // Step 3: Calculate the sum using the formula
                    int formulaSum = SumUsingFormula(n);

                    // Step 4: Display the results
                    Console.WriteLine($"\nSum of first {n} natural numbers (using recursion): {recursiveSum}");
                    Console.WriteLine($"Sum of first {n} natural numbers (using formula): {formulaSum}");

                    // Step 5: Confirm the results match
                    if (recursiveSum == formulaSum)
                    {
                        Console.WriteLine("The results from both methods are correct and match!");
                    }
                    else
                    {
                        Console.WriteLine("The results do not match. Please check the methods for errors.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a natural number (positive integer).");
                }
            }

            // Method to check if the input is a valid natural number
            private static bool IsNaturalNumber(string input)
            {
                foreach (char c in input)
                {
                    if (!char.IsDigit(c)) // Check if every character is a digit
                    {
                        return false;
                    }
                }
                return input.Length > 0 && Convert.ToInt32(input) > 0; // Ensure it's positive
            }

            // Recursive method to calculate the sum of n natural numbers
            private static int SumUsingRecursion(int n)
            {
                if (n == 1) // Base case
                {
                    return 1;
                }
                return n + SumUsingRecursion(n - 1); // Recursive case
            }

            // Method to calculate the sum of n natural numbers using the formula
            private static int SumUsingFormula(int n)
            {
                return n * (n + 1) / 2; // Formula: n * (n + 1) / 2
            }
        }
}

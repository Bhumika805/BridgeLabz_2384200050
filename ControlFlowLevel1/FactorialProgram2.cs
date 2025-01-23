using System;

namespace ControlFlowLevel1
{
    class FactorialProgram2
    {
        public void Factorial2()
        {
            // Input: Get an integer from the user
            Console.Write("Enter a positive integer to find its factorial: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Check if the user entered a positive integer
            if (number >= 0)
            {
                int factorial = 1; // Variable to store the factorial result

                // Compute the factorial using a for loop
                for (int i = 1; i <= number; i++)
                {
                    factorial *= i; // Multiply the current value of factorial by i
                }

                // Output the factorial result
                Console.WriteLine($"The factorial of {number} is {factorial}.");
            }
            else
            {
                // If the number is negative, display an error message
                Console.WriteLine("Factorial is not defined for negative numbers. Please enter a positive integer.");
            }
        }
    }
}

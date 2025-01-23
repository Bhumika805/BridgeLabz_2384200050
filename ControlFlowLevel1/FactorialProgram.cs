using System;

namespace ControlFlowLevel1
{
    class FactorialProgram
    {
        public void Factorial()
        {
            // Input: Get an integer from the user
            Console.Write("Enter a positive integer to find its factorial: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Check if the user entered a positive integer
            if (number >= 0)
            {
                int factorial = 1; // Variable to store the factorial result
                int i = 1;         // Loop counter

                // Compute the factorial using a while loop
                while (i <= number)
                {
                    factorial *= i; // Multiply the current value of factorial by i
                    i++;            // Increment i
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

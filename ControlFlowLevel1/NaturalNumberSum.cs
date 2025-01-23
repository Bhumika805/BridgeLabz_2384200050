using System;

namespace ControlFlowLevel1
{
    class NaturalNumberSum
    {
        public void CalculateSum()
        {
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            // Check if the number is a natural number (positive integer)
            if (number >= 0)
            {
                // Calculate the sum of n natural numbers using the formula n * (n + 1) / 2
                int sum = number * (number + 1) / 2;

                // Output the sum
                Console.WriteLine($"The sum of {number} natural numbers is {sum}");
            }
            else
            {
                // Output if the number is not a natural number
                Console.WriteLine($"The number {number} is not a natural number");
            }
        }
    }
}

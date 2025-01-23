using System;

namespace ControlFlowLevel1
{
    class SumUntilZeroOrNegative
    {
        public void SumUntilZero___Negative()
        {
            // Initialize the total variable
            double total = 0.0;

            Console.WriteLine("Enter numbers to calculate the sum (Enter 0 or a negative number to stop):");

            // Use an infinite while loop
            while (true)
            {
                // Get user input
                Console.Write("Enter a number: ");
                double userInput = Convert.ToDouble(Console.ReadLine());

                // Check if the input is 0 or negative
                if (userInput <= 0)
                {
                    break; // Exit the loop
                }

                // Add the input value to the total
                total += userInput;
            }

            // Display the total sum
            Console.WriteLine($"\nThe total sum of the numbers entered is: {total}");
        }
    }
}

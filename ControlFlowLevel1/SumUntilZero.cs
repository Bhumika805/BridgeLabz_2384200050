using System;

namespace ControlFlowLevel1
{
    class SumUntilZero
    {
        public void SumZero()
        {
            // Initialize the total variable
            double total = 0.0;

            // Variable to store user input
            double userInput;

            Console.WriteLine("Enter numbers to calculate the sum (Enter 0 to stop):");

            // Use a while loop to keep asking for input until 0 is entered
            while (true)
            {
                // Get user input
                Console.Write("Enter a number: ");
                userInput = Convert.ToDouble(Console.ReadLine());

                // Check if the input is 0
                if (userInput == 0)
                {
                    break; // Exit the loop if input is 0
                }

                // Add the input value to the total
                total += userInput;
            }

            // Display the total sum
            Console.WriteLine($"\nThe total sum of the numbers entered is: {total}");
        }
    }
}

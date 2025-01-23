using System;

namespace ControlFlowLevel3
{
    class AbundantNumber
    {
        public void CheckAbundantNumber()
        {
            // Input the number
            Console.Write("Enter a number to check if it's an Abundant number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Initialize sum to 0
            int sum = 0;

            // Run a for loop from i = 1 to i < number
            for (int i = 1; i < number; i++)
            {
                // Check if number is divisible by i
                if (number % i == 0)
                {
                    // Add i to sum if true
                    sum += i;
                }
            }

            // Check if sum is greater than the number
            if (sum > number)
            {
                Console.WriteLine($"{number} is an Abundant number.");
            }
            else
            {
                Console.WriteLine($"{number} is not an Abundant number.");
            }
        }
    }
}

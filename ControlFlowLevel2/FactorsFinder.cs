using System;

namespace ControlFlowLevel2
{
    class FactorsFinder
    {
        public void Factor__Finder()
        {
            // Input: Get the number from the user
            Console.WriteLine("Enter a number to find its factors: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The factors of {number} are:");

            // Loop to find the factors
            for (int i = 1; i <= number; i++) // Loop from 1 to the number
            {
                if (number % i == 0) // Check if the number is divisible by i
                {
                    Console.WriteLine(i); // Print the factor
                }
            }
        }
    }
}

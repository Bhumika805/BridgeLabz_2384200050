using System;

namespace ArrayLevel1
{
    class MultiplicationTable
    {
        public void Table()
        {
            Console.Write($"Enter a number to print its multiplication table: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Define arrays to store multipliers and results
            int[] multipliers = new int[10];
            int[] multiplicationTable = new int[10];

            // Fill the multipliers array with values from 1 to 10
            for (int i = 0; i < multipliers.Length; i++)
            {
                multipliers[i] = i + 1; // multipliers will store numbers 1 to 10
            }

            // Calculate the multiplication table and store the results in the multiplicationTable array
            for (int i = 0; i < multiplicationTable.Length; i++)
            {
                multiplicationTable[i] = number * multipliers[i]; // Store results in multiplicationTable array
            }

            // Display the multiplication table
            Console.WriteLine($"\nMultiplication table for " + number + ":");
            for (int i = 0; i < multiplicationTable.Length; i++)
            {
                // Display the formatted result using the arrays
                Console.WriteLine(number + " * " + multipliers[i] + " = " + multiplicationTable[i]);
            }
        }
    }
}

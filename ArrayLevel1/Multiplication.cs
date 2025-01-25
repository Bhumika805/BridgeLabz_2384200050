using System;

namespace ArrayLevel1
{
    class Multiplication
    {
        public void Tables()
        {
            Console.Write("Enter a number to display the multiplication table for 6 to 9: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Define arrays to store multipliers (6, 7, 8, 9) and multiplication results
            int[] multipliers = new int[] { 6, 7, 8, 9 };
            int[] multiplicationResult = new int[4]; // Array to store results

            // Loop through the multipliers array to calculate the multiplication results
            for (int i = 0; i < multipliers.Length; i++)
            {
                multiplicationResult[i] = number * multipliers[i]; // Store the result
            }

            // Display the multiplication tables using the arrays
            Console.WriteLine("\nMultiplication table for " + number + " from 6 to 9:");
            for (int i = 0; i < multipliers.Length; i++)
            {
                Console.WriteLine(number + " * " + multipliers[i] + " = " + multiplicationResult[i]);
            }
        }
    }
}

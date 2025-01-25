using System;

namespace ArrayLevel1
{
    class FactorFinder
    {
        public void Factor__Finder()
        {
            Console.Write("Enter a number to find its factors: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number <= 0)
            {
                Console.WriteLine("Error: Please enter a positive number.");
                return;
            }

            // Initialize variables for the factors array
            int maxFactor = 10; // Initial size of the factors array
            int[] factors = new int[maxFactor]; // Array to store factors
            int index = 0; // Current index of the factors array

            // Find the factors of the number
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0) // Check if 'i' is a factor
                {
                    // If the array is full, double its size
                    if (index == maxFactor)
                    {
                        maxFactor *= 2; // Double the size
                        int[] temp = new int[maxFactor]; // Create a larger array
                        
                        // Copy elements from the old array to the new array
                        for (int j = 0; j < factors.Length; j++)
                        {
                            temp[j] = factors[j];
                        }

                        factors = temp; // Assign the new array to factors
                    }

                    // Add the factor to the array and increment the index
                    factors[index] = i;
                    index++;
                }
            }

            // Display the factors of the number
            Console.WriteLine("\nFactors of " + number + ":");
            for (int i = 0; i < index; i++)
            {
                Console.Write(factors[i] + " ");
            }

            Console.WriteLine(); // For clean output formatting
        }
    }
}

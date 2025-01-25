using System;

namespace ArrayLevel1
{
    class OddEvenArrays
    {
        public void CheckOddEvenArrays()
        {
            Console.Write("Enter a natural number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Check if the input is a natural number (positive integer)
            if (number <= 0)
            {
                Console.WriteLine("Error: Please enter a natural number greater than zero.");
                return; // Exit the program if the number is invalid
            }

            // Create arrays to store odd and even numbers
            int[] oddNumbers = new int[number / 2 + 1]; // Maximum size for odd numbers
            int[] evenNumbers = new int[number / 2 + 1]; // Maximum size for even numbers

            // Initialize index variables for odd and even numbers
            int oddIndex = 0, evenIndex = 0;

            // Iterate from 1 to the entered number
            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0) // Check if the number is even
                {
                    evenNumbers[evenIndex] = i; // Add the number to the even array
                    evenIndex++; // Increment the even index
                }
                else // The number is odd
                {
                    oddNumbers[oddIndex] = i; // Add the number to the odd array
                    oddIndex++; // Increment the odd index
                }
            }

            // Print the even numbers array
            Console.WriteLine("\nEven numbers:");
            for (int i = 0; i < evenIndex; i++) // Use the evenIndex as the limit
            {
                Console.Write(evenNumbers[i] + " ");
            }

            // Print the odd numbers array
            Console.WriteLine("\n\nOdd numbers:");
            for (int i = 0; i < oddIndex; i++) // Use the oddIndex as the limit
            {
                Console.Write(oddNumbers[i] + " ");
            }

            Console.WriteLine(); // For clean output formatting
        }
    }
}

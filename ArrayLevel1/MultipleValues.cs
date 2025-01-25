using System;

namespace ArrayLevel1
{
    class MultipleValues
    {
        public void Multiple__Value()
        {
            // Define an array of 10 elements of type double
            double[] numbers = new double[10];
            double total = 0.0;  // Variable to store the sum of numbers
            int index = 0;  // Index to keep track of the number of elements entered

            // Infinite loop to accept user input
            while (true)
            {
                // Take user input
                Console.Write("Enter a number (enter 0 or a negative number to stop): ");
                double input = Convert.ToDouble(Console.ReadLine());

                // Check if the user entered 0 or a negative number or if the array is full
                if (input <= 0 || index >= 10)
                {
                    break;  // Exit the loop
                }

                // Store the valid number in the array and increment the index
                numbers[index] = input;
                index++;
            }

            // Calculate the total of the numbers entered
            for (int i = 0; i < index; i++)
            {
                total += numbers[i];
            }

            // Display the numbers entered
            Console.WriteLine("\nNumbers entered:");
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            // Display the total sum of the numbers
            Console.WriteLine("\nTotal sum of entered numbers: " + total);
        }
    }
}

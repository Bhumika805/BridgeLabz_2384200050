using System;

namespace ArrayLevel2
{
    class DigitFrequency
    {
        public void Digit__Frequency()
        {
            Console.Write("Enter a number: ");
            long number = Convert.ToInt64(Console.ReadLine());

            // Convert the number to string to extract digits easily
            string numberStr = number.ToString();

            // Create an array to store the frequency of each digit (0-9)
            int[] frequency = new int[10];

            // Loop through each character in the string representation of the number
            foreach (char digit in numberStr)
            {
                // Convert the character to its numeric value and update the frequency array
                int digitValue = digit - '0';  // Converts char '0'-'9' to the corresponding integer
                frequency[digitValue]++;
            }

            // Display the frequency of each digit
            Console.WriteLine("\nDigit Frequencies:");
            for (int i = 0; i < 10; i++)
            {
                if (frequency[i] > 0) // Only print digits that appear in the number
                {
                    Console.WriteLine($"Digit {i}: {frequency[i]} times");
                }
            }
        }
    }
}

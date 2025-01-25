using System;

namespace ArrayLevel2
{
    class ReverseNumber
    {
        public void ReverseOrder()
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int temp = number;
            int digitCount = 0;
            while (temp != 0)
            {
                temp /= 10;
                digitCount++;
            }

            // Create an array to store digits of the number
            int[] digits = new int[digitCount];
            int index = 0;

            // Store the digits in the array
            temp = number;
            while (temp != 0)
            {
                digits[index] = temp % 10;  // Get the last digit
                temp /= 10;  // Remove the last digit
                index++;
            }

            // Display the digits in reverse order
            Console.Write("Reversed number: ");
            for (int i = 0; i < digits.Length; i++)
            {
                Console.Write(digits[i]);
            }
            Console.WriteLine();
        }
    }
}

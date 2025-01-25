using System;

namespace ArrayLevel2
{
    class LargestSecondLargest
    {
        public void LargestElement()
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Initialize array to store digits and maxDigit to set array size
            int maxDigit = 10;
            int[] digits = new int[maxDigit];
            int index = 0;

            // Loop to extract digits and store them in the array
            while (number != 0)
            {
                // Extract the last digit and store it in the array
                digits[index] = number % 10;
                // Remove the last digit from the number
                number /= 10;
                // Increment index for the next digit
                index++;

                // Break the loop if the number of digits exceeds the max size
                if (index == maxDigit)
                    break;
            }

            // Initialize variables to store the largest and second largest digit
            int largest = int.MinValue;
            int secondLargest = int.MinValue;

            // Loop through the digits array to find the largest and second largest elements
            for (int i = 0; i < index; i++)
            {
                if (digits[i] > largest)
                {
                    secondLargest = largest; // Update second largest
                    largest = digits[i];     // Update largest
                }
                else if (digits[i] > secondLargest && digits[i] != largest)
                {
                    secondLargest = digits[i]; // Update second largest
                }
            }

            // Display the largest and second largest digits
            Console.WriteLine($"The largest digit is: {largest}");
            Console.WriteLine($"The second largest digit is: {secondLargest}");
        }
    }
}

using System;

namespace ControlFlowLevel3
{
    class HarshadNumber
    {
        public void CheckHarshadNumber()
        {
            Console.Write("Enter a number to check if it's a Harshad number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Initialize sum to 0
            int sum = 0;
            int originalNumber = number;

            // Create a while loop to access each digit of the number
            while (number != 0)
            {
                // Find the last digit using modulus operator
                int remainder = number % 10;

                // Add the digit to the sum
                sum += remainder;

                // Remove the last digit by dividing the number by 10
                number /= 10;
            }

            // Check if the number is divisible by the sum of its digits
            if (originalNumber % sum == 0)
            {
                Console.WriteLine($"{originalNumber} is a Harshad number.");
            }
            else
            {
                Console.WriteLine($"{originalNumber} is not a Harshad number.");
            }
        }
    }
}

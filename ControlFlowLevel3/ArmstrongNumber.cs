using System;

namespace ControlFlowLevel3
{ 
class ArmstrongNumber
{
    public void ArmstrongNum()
    {
        Console.Write("Enter a number to check if it's an Armstrong number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Initialize sum to zero and store the original number
        int sum = 0;
        int originalNumber = number;

        // Use a while loop to process each digit
        while (number != 0)
        {
            // Find the last digit using modulus operator
            int remainder = number % 10;

            // Cube the digit and add it to the sum
            sum += remainder * remainder * remainder;

            // Remove the last digit by dividing the number by 10
            number /= 10;
        }

        // Check if the sum is equal to the original number
        if (sum == originalNumber)
        {
            Console.WriteLine($"{originalNumber} is an Armstrong number.");
        }
        else
        {
            Console.WriteLine($"{originalNumber} is not an Armstrong number.");
        }
    }
}
}

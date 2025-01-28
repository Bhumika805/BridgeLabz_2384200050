using System;

namespace PracticeProblem1
{
    class QuotientAndRemainder
    {
        public void Quotient__Remainder()
        {
            // Prompt the user to enter two numbers
            Console.Write("Enter the first number (dividend): ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number (divisor): ");
            int divisor = Convert.ToInt32(Console.ReadLine());

            // Call the method to find the quotient and remainder
            int[] result = FindRemainderAndQuotient(number, divisor);

            // Output the quotient and remainder
            Console.WriteLine($"\nThe quotient is: {result[0]}");
            Console.WriteLine($"The remainder is: {result[1]}");
        }

        // Method to find the quotient and remainder of two numbers
        public static int[] FindRemainderAndQuotient(int number, int divisor)
        {
            int quotient = number / divisor;    // Use division operator for quotient
            int remainder = number % divisor;   // Use modulus operator for remainder

            return new int[] { quotient, remainder }; // Return quotient and remainder in an array
        }
    }
}

using System;

namespace PracticeProblem1
{
    class ChocolateDivision
    {
        public void Chocolate__Division()
        {
            // Prompt the user to enter the total number of chocolates and the number of children
            Console.Write("Enter the total number of chocolates: ");
            int numberOfChocolates = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the number of children: ");
            int numberOfChildren = Convert.ToInt32(Console.ReadLine());

            // Call the method to find the quotient (chocolates per child) and remainder (remaining chocolates)
            int[] result = FindRemainderAndQuotient(numberOfChocolates, numberOfChildren);

            // Output the result
            Console.WriteLine($"\nEach child will get: {result[0]} chocolates");
            Console.WriteLine($"Remaining chocolates: {result[1]}");
        }

        // Method to find the quotient (chocolates per child) and remainder (remaining chocolates)
        public static int[] FindRemainderAndQuotient(int number, int divisor)
        {
            int chocolatesPerChild = number / divisor;  // Use division for quotient
            int remainingChocolates = number % divisor; // Use modulus for remainder

            return new int[] { chocolatesPerChild, remainingChocolates }; // Return result in an array
        }
    }
}

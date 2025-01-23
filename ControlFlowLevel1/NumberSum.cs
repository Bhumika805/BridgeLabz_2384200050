using System;

namespace ControlFlowLevel1
{
    class NumberSum
    {
        public void Numbers()
        {
            Console.Write("Enter a positive integer (natural number): ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Check if the number is a natural number
            if (n > 0)
            {
                // Compute the sum using the formula
                int formulaSum = n * (n + 1) / 2;

                // Compute the sum using a for loop
                int loopSum = 0;
                for (int i = 1; i <= n; i++)
                {
                    loopSum += i;
                }

                // Display the results
                Console.WriteLine($"\nSum using formula: {formulaSum}");
                Console.WriteLine($"Sum using for loop: {loopSum}");

                // Compare the results
                if (formulaSum == loopSum)
                {
                    Console.WriteLine("Both results match. The computations are correct!");
                }
                else
                {
                    Console.WriteLine("There is a discrepancy between the two computations.");
                }
            }
            else
            {
                // If the number is not a natural number
                Console.WriteLine("The entered number is not a natural number. Please enter a positive integer.");
            }
        }
    }
}

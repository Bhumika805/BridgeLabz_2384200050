using System;

namespace ControlFlowLevel1
{
    class NaturalNumber
    {
        public void NaturalNumberSum()
        {
            Console.Write("Enter a positive integer (natural number): ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Check if the number is a natural number
            if (n > 0)
            {
                // Compute the sum using the formula
                int formulaSum = n * (n + 1) / 2;

                // Compute the sum using a while loop
                int loopSum = 0;
                int counter = 1;
                while (counter <= n)
                {
                    loopSum += counter;
                    counter++;
                }

                // Display the results
                Console.WriteLine($"\nSum using formula: {formulaSum}");
                Console.WriteLine($"Sum using while loop: {loopSum}");

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

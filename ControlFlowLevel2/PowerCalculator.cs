using System;

namespace ControlFlowLevel2
{
    class PowerCalculator
    {
        public void Calculation()
        {
            // Input: Get the base number
            Console.WriteLine("Enter the base number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Input: Get the power
            Console.WriteLine("Enter the power: ");
            int power = Convert.ToInt32(Console.ReadLine());

            // Initialize the result variable to 1
            int result = 1;

            // Loop to calculate the power
            for (int i = 1; i <= power; i++)
            {
                result *= number; // Multiply result by the number in each iteration
            }

            // Output the result
            Console.WriteLine($"{number} raised to the power of {power} is: {result}");
        }
    }
}

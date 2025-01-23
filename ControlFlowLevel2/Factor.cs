using System;

namespace ControlFlowLevel2
{
    class Factor
    {
        public void greatest_Factor()
        {
            // Input: Get an integer from the user
            Console.WriteLine("Enter an integer: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Initialize the greatestFactor variable
            int greatestFactor = 1;

            // Loop from (number - 1) to 1
            for (int i = number - 1; i >= 1; i--)
            {
                // Check if the number is perfectly divisible by i
                if (number % i == 0)
                {
                    greatestFactor = i; // Assign the value to greatestFactor
                    break; // Exit the loop
                }
            }

            // Output the greatest factor
            Console.WriteLine($"The greatest factor of {number} (other than itself) is: {greatestFactor}");
        }
    }
}

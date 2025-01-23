using System;

namespace ControlFlowLevel1
{
    class OddEvenProgram
    {
        public void OddEven()
        {
            Console.Write("Enter a positive integer: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Check if the input is a Natural Number
            if (number > 0)
            {
                Console.WriteLine($"Odd and Even numbers from 1 to {number}:");

                // Loop through numbers from 1 to the user-entered number
                for (int i = 1; i <= number; i++)
                {
                    // Check if the number is even
                    if (i % 2 == 0)
                    {
                        Console.WriteLine($"{i} is an even number.");
                    }
                    else // Otherwise, it's odd
                    {
                        Console.WriteLine($"{i} is an odd number.");
                    }
                }
            }
            else
            {
                // If the input is not a natural number
                Console.WriteLine("Please enter a positive integer greater than 0.");
            }
        }
    }
}

using System;

namespace ControlFlowLevel2
{
    class FizzBuzzProgram2
    {
        public void FizzBuzz2()
        {
            // Input: Get a number from the user
            Console.WriteLine("Enter a positive integer: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Check if the number is positive
            if (number > 0)
            {
                Console.WriteLine("FizzBuzz Results:");
                
                // Initialize counter
                int i = 0;

                // Loop while counter is less than or equal to the given number
                while (i <= number)
                {
                    
                    if (number % 3 == 0 && number % 5 == 0) // Multiple of 3
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else if (number % 5 == 0 && i % 5 == 0) // Multiple of 5
                    {
                        Console.WriteLine("Buzz");
                    }
					else if (number % 3 == 0 && i % 3 == 0) // Multiple of both 3 and 5
                    {
                        Console.WriteLine("Fizz");
                    }
					
                    else // Print the number itself
                    {
                        Console.WriteLine(i);
                    }
                    i++;
                }
            }
            else
            {
                Console.WriteLine("Please enter a positive integer.");
            }
        }
    }
}

using System;

namespace ControlFlowLevel2
{
    class PrimeNumberCheck
    {
        public void PrimeNumber()
        {
            // Input: Get the number from the user
            Console.WriteLine("Enter a number to check if it is a prime number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Check if the number is prime
            bool isPrime = true;

            // Prime numbers are greater than 1
            if (number == 1)
            {
                isPrime = false;
				Console.WriteLine($"It is {isPrime}");
            }
            else
            {
                // Loop from 2 to the square root of the number
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0) // If divisible by any number
                    {
                        isPrime = false;
                        break; // No need to check further
                    }
                }
            }

            // Output the result
            if (isPrime)
            {
                Console.WriteLine($"The number {number} is a prime number.");
				Console.WriteLine($"It is {isPrime}");
            }
            else
            {
                Console.WriteLine($"The number {number} is not a prime number.");
				Console.WriteLine($"It is {isPrime}");
            }
        }
    }
}

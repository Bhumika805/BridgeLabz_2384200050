using System;

namespace  ArrayLevel1
{
    class FizzBuzzProgram
    {
        public void FizzBuzz()
        {
            Console.Write("Enter a positive integer: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Validate input
            if (number <= 0)
            {
                Console.WriteLine("Please enter a positive integer.");
                return;
            }

            // Create a string array to store FizzBuzz results
            string[] results = new string[number + 1];

            // Loop from 0 to the user-provided number
            for (int i = 0; i <= number; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) // Multiple of both 3 and 5
                    results[i] = "FizzBuzz";
                else if (i % 3 == 0) // Multiple of 3
                    results[i] = "Fizz";
                else if (i % 5 == 0) // Multiple of 5
                    results[i] = "Buzz";
                else // Other numbers
                    results[i] = i.ToString();
            }

            // Display the results with position information
            Console.WriteLine("\nFizzBuzz Results:");
            for (int i = 0; i <= number; i++)
                Console.WriteLine($"Position {i} = {results[i]}");
        }
    }
}

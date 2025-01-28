using System;

namespace PracticeProblem1
{
    class NumberCheck
    {
        public void Number_Checker()
        {
            Console.Write("Enter an integer: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Call the method to determine the sign of the number
            int result = CheckNumber(number);

            // Output the result
            if (result == 1)
            {
                Console.WriteLine("The number is positive.");
            }
            else if (result == -1)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }
        }

        // Method to check if a number is positive, negative, or zero
        static int CheckNumber(int num)
        {
            if (num > 0)
            {
                return 1; // Positive number
            }
            else if (num < 0)
            {
                return -1; // Negative number
            }
            else
            {
                return 0; // Zero
            }
        }
    }
}

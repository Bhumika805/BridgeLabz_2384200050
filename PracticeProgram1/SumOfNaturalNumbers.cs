using System;

namespace PracticeProblem1
{
    class SumOfNaturalNumbers
    {
        public void SumOfNatural__Numbers()
        {
            // Prompt the user to enter a positive integer
            Console.Write("Enter a positive integer (n): ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n > 0)
            {
                // Call the method to calculate the sum
                int sum = CalculateSum(n);

                // Display the result
                Console.WriteLine($"The sum of the first {n} natural numbers is: {sum}");
            }
            else
            {
                Console.WriteLine("Please enter a positive integer greater than zero.");
            }
        }

        // Method to calculate the sum of n natural numbers using a loop
        static int CalculateSum(int n)
        {
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }

            return sum;
        }
    }
}

using System;

namespace PracticeProblem2
{
    class FactorsOfNumber
    {
        public void DisplayFactorsResult()
        {
            Console.Write("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Find factors
            int[] factors = FindFactors(number);

            // Display factors
            Console.WriteLine("Factors:");
            foreach (int factor in factors)
            {
                Console.Write(factor + " ");
            }
            Console.WriteLine();

            // Calculate and display results
            int sum = CalculateSum(factors);
            Console.WriteLine("Sum of factors: " + sum);

            long product = CalculateProduct(factors);
            Console.WriteLine("Product of factors: " + product);

            double sumOfSquares = CalculateSumOfSquares(factors);
            Console.WriteLine("Sum of squares of factors: " + sumOfSquares);
        }

        // Method to find factors and return them as an array
        static int[] FindFactors(int number)
        {
            int count = 0;

            // First loop: Count the factors
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }

            // Initialize the array to store factors
            int[] factors = new int[count];
            int index = 0;

            // Second loop: Store the factors in the array
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    factors[index] = i;
                    index++;
                }
            }

            return factors;
        }

        // Method to calculate the sum of factors
        static int CalculateSum(int[] factors)
        {
            int sum = 0;
            foreach (int factor in factors)
            {
                sum += factor;
            }
            return sum;
        }

        // Method to calculate the product of factors
        static long CalculateProduct(int[] factors)
        {
            long product = 1;
            foreach (int factor in factors)
            {
                product *= factor;
            }
            return product;
        }

        // Method to calculate the sum of squares of factors
        static double CalculateSumOfSquares(int[] factors)
        {
            double sumOfSquares = 0;
            foreach (int factor in factors)
            {
                sumOfSquares += Math.Pow(factor, 2); // Square each factor and add to the sum
            }
            return sumOfSquares;
        }
    }
}

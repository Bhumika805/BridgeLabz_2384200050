using System;

namespace PracticeProblem3
{
    public class NumberChecker5
    {
        // Method to find factors of a number
        public static int[] FindFactors(int number)
        {
            int count = 0;

            // Count factors
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0) count++;
            }

            // Store factors in an array
            int[] factors = new int[count];
            int index = 0;

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    factors[index++] = i;
                }
            }

            return factors;
        }

        // Method to find the greatest factor of a number
        public static int FindGreatestFactor(int[] factors)
        {
            return factors[^1]; // The last element in the sorted factors array is the greatest factor
        }

        // Method to find the sum of factors
        public static int FindSumOfFactors(int[] factors)
        {
            int sum = 0;
            foreach (int factor in factors)
            {
                sum += factor;
            }
            return sum;
        }

        // Method to find the product of factors
        public static long FindProductOfFactors(int[] factors)
        {
            long product = 1;
            foreach (int factor in factors)
            {
                product *= factor;
            }
            return product;
        }

        // Method to find the product of the cube of factors
        public static long FindProductOfCubeOfFactors(int[] factors)
        {
            long product = 1;
            foreach (int factor in factors)
            {
                product *= (long)Math.Pow(factor, 3);
            }
            return product;
        }

        // Method to check if a number is a perfect number
        public static bool IsPerfectNumber(int number)
        {
            int[] factors = FindFactors(number);
            int sum = FindSumOfFactors(factors) - number; // Exclude the number itself
            return sum == number;
        }

        // Method to check if a number is an abundant number
        public static bool IsAbundantNumber(int number)
        {
            int[] factors = FindFactors(number);
            int sum = FindSumOfFactors(factors) - number; // Exclude the number itself
            return sum > number;
        }

        // Method to check if a number is a deficient number
        public static bool IsDeficientNumber(int number)
        {
            int[] factors = FindFactors(number);
            int sum = FindSumOfFactors(factors) - number; // Exclude the number itself
            return sum < number;
        }

        // Method to check if a number is a strong number
        public static bool IsStrongNumber(int number)
        {
            int sumOfFactorials = 0;
            int temp = number;

            while (temp > 0)
            {
                int digit = temp % 10;
                sumOfFactorials += Factorial(digit);
                temp /= 10;
            }

            return sumOfFactorials == number;
        }

        // Helper method to calculate factorial
        private static int Factorial(int n)
        {
            if (n == 0 || n == 1) return 1;

            int result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}

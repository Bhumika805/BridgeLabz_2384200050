using System;

namespace PracticeProblem3
{
    public class NumberChecker
    {
        // Method to find the count of digits in a number
        public static int CountDigits(int number)
        {
            return number.ToString().Length;
        }

        // Method to store the digits of a number in an array
        public static int[] GetDigitsArray(int number)
        {
            string numString = number.ToString();
            int[] digits = new int[numString.Length];
            for (int i = 0; i < numString.Length; i++)
            {
                digits[i] = int.Parse(numString[i].ToString());
            }
            return digits;
        }

        // Method to check if the number is a duck number
        public static bool IsDuckNumber(int number)
        {
            string numString = number.ToString();
            return numString.Contains('0');
        }

        // Method to check if the number is an Armstrong number
        public static bool IsArmstrongNumber(int number)
        {
            int[] digits = GetDigitsArray(number);
            int power = digits.Length;
            int sum = 0;

            foreach (int digit in digits)
            {
                sum += (int)Math.Pow(digit, power);
            }

            return sum == number;
        }

        // Method to find the largest and second largest digits
        public static (int largest, int secondLargest) FindLargestAndSecondLargest(int[] digits)
        {
            int largest = int.MinValue;
            int secondLargest = int.MinValue;

            foreach (int digit in digits)
            {
                if (digit > largest)
                {
                    secondLargest = largest;
                    largest = digit;
                }
                else if (digit > secondLargest && digit != largest)
                {
                    secondLargest = digit;
                }
            }

            return (largest, secondLargest);
        }

        // Method to find the smallest and second smallest digits
        public static (int smallest, int secondSmallest) FindSmallestAndSecondSmallest(int[] digits)
        {
            int smallest = int.MaxValue;
            int secondSmallest = int.MaxValue;

            foreach (int digit in digits)
            {
                if (digit < smallest)
                {
                    secondSmallest = smallest;
                    smallest = digit;
                }
                else if (digit < secondSmallest && digit != smallest)
                {
                    secondSmallest = digit;
                }
            }

            return (smallest, secondSmallest);
        }

        // Main method to call the utility methods and display the results
        public static void Main()
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nNumber: {number}");

            // Count of digits
            int count = CountDigits(number);
            Console.WriteLine($"Count of Digits: {count}");

            // Digits array
            int[] digits = GetDigitsArray(number);
            Console.WriteLine("Digits: " + string.Join(", ", digits));

            // Check for Duck number
            bool isDuck = IsDuckNumber(number);
            Console.WriteLine($"Is Duck Number: {isDuck}");

            // Check for Armstrong number
            bool isArmstrong = IsArmstrongNumber(number);
            Console.WriteLine($"Is Armstrong Number: {isArmstrong}");

            // Find largest and second largest digits
            var (largest, secondLargest) = FindLargestAndSecondLargest(digits);
            Console.WriteLine($"Largest Digit: {largest}");
            Console.WriteLine($"Second Largest Digit: {secondLargest}");

            // Find smallest and second smallest digits
            var (smallest, secondSmallest) = FindSmallestAndSecondSmallest(digits);
            Console.WriteLine($"Smallest Digit: {smallest}");
            Console.WriteLine($"Second Smallest Digit: {secondSmallest}");
        }
    }
}

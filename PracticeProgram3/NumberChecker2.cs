using System;

namespace PracticeProblem3
{
    public class NumberChecker2
    {
        // Method to find the count of digits in the number
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

        // Method to find the sum of the digits of a number
        public static int SumOfDigits(int[] digits)
        {
            int sum = 0;
            foreach (int digit in digits)
            {
                sum += digit;
            }
            return sum;
        }

        // Method to find the sum of the squares of the digits of a number
        public static int SumOfSquaresOfDigits(int[] digits)
        {
            int sum = 0;
            foreach (int digit in digits)
            {
                sum += (int)Math.Pow(digit, 2);
            }
            return sum;
        }

        // Method to check if a number is a Harshad number
        public static bool IsHarshadNumber(int number, int[] digits)
        {
            int sumOfDigits = SumOfDigits(digits);
            return number % sumOfDigits == 0;
        }

        // Method to find the frequency of each digit in the number
        public static int[,] FindDigitFrequencies(int number)
        {
            int[] digits = GetDigitsArray(number);
            int[,] frequencies = new int[10, 2];

            // Initialize digit values
            for (int i = 0; i < 10; i++)
            {
                frequencies[i, 0] = i; 
                frequencies[i, 1] = 0; 
            }

            // Count the frequency of each digit
            foreach (int digit in digits)
            {
                frequencies[digit, 1]++;
            }

            return frequencies;
        }
		
		public void Input()
        {
            int number = Convert.ToInt32(Console.ReadLine());;
            int[] digits = NumberChecker2.GetDigitsArray(number);

            // Count digits
            int digitCount = NumberChecker2.CountDigits(number);
            Console.WriteLine($"Number of digits in {number}: {digitCount}");

            // Sum of digits
            int sumOfDigits = NumberChecker2.SumOfDigits(digits);
            Console.WriteLine($"Sum of digits: {sumOfDigits}");

            // Sum of squares of digits
            int sumOfSquares = NumberChecker2.SumOfSquaresOfDigits(digits);
            Console.WriteLine($"Sum of squares of digits: {sumOfSquares}");

            // Check if the number is a Harshad number
            bool isHarshad = NumberChecker2.IsHarshadNumber(number, digits);
            Console.WriteLine($"{number} is a Harshad number: {isHarshad}");

            // Find digit frequencies
            int[,] frequencies = NumberChecker2.FindDigitFrequencies(number);
            Console.WriteLine("Digit frequencies:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Digit {frequencies[i, 0]}: {frequencies[i, 1]}");
            }
        }
    }
}

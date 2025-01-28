using System;

namespace PracticeProblem3
{
    public class NumberChecker4
    {
        // Method to check if a number is a prime number
        public static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

        // Method to check if a number is a neon number
        public static bool IsNeon(int number)
        {
            int square = number * number;
            int sumOfDigits = 0;

            while (square > 0)
            {
                sumOfDigits += square % 10;
                square /= 10;
            }

            return sumOfDigits == number;
        }

        // Method to check if a number is a spy number
        public static bool IsSpy(int number)
        {
            int sumOfDigits = 0;
            int productOfDigits = 1;

            while (number > 0)
            {
                int digit = number % 10;
                sumOfDigits += digit;
                productOfDigits *= digit;
                number /= 10;
            }

            return sumOfDigits == productOfDigits;
        }

        // Method to check if a number is an automorphic number
        public static bool IsAutomorphic(int number)
        {
            int square = number * number;
            return square.ToString().EndsWith(number.ToString());
        }

        // Method to check if a number is a buzz number
        public static bool IsBuzz(int number)
        {
            return number % 7 == 0 || number % 10 == 7;
        }
		
		public void Input()
        {
            int number1 = 7;  // Buzz number
            int number2 = 28; // Prime number
            int number3 = 9;  // Neon number
            int number4 = 36; // Automorphic number
            int number5 = 1124; // Spy number

            // Check if number1 is a Buzz number
            bool isBuzz = NumberChecker4.IsBuzz(number1);
            Console.WriteLine($"{number1} is a Buzz number: {isBuzz}");

            // Check if number2 is a Prime number
            bool isPrime = NumberChecker4.IsPrime(number2);
            Console.WriteLine($"{number2} is a Prime number: {isPrime}");

            // Check if number3 is a Neon number
            bool isNeon = NumberChecker4.IsNeon(number3);
            Console.WriteLine($"{number3} is a Neon number: {isNeon}");

            // Check if number4 is an Automorphic number
            bool isAutomorphic = NumberChecker4.IsAutomorphic(number4);
            Console.WriteLine($"{number4} is an Automorphic number: {isAutomorphic}");

            // Check if number5 is a Spy number
            bool isSpy = NumberChecker4.IsSpy(number5);
            Console.WriteLine($"{number5} is a Spy number: {isSpy}");
        }
    }
}

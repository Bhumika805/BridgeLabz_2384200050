using System;

namespace PracticeProblem3
{
    public class NumberChecker3
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

        // Method to reverse the digits array
        public static int[] ReverseDigitsArray(int[] digits)
        {
            int[] reversed = new int[digits.Length];
            for (int i = 0; i < digits.Length; i++)
            {
                reversed[i] = digits[digits.Length - 1 - i];
            }
            return reversed;
        }

        // Method to compare two arrays and check if they are equal
        public static bool AreArraysEqual(int[] array1, int[] array2)
        {
            if (array1.Length != array2.Length)
                return false;

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                    return false;
            }
            return true;
        }

        // Method to check if a number is a palindrome
        public static bool IsPalindrome(int number)
        {
            int[] digits = GetDigitsArray(number);
            int[] reversed = ReverseDigitsArray(digits);
            return AreArraysEqual(digits, reversed);
        }

        // Method to check if a number is a duck number
        public static bool IsDuckNumber(int number)
        {
            int[] digits = GetDigitsArray(number);
            foreach (int digit in digits)
            {
                if (digit == 0)
                    return true;
            }
            return false;
        }
		
		public void Input()
        {
            int number1 = Convert.ToInt32(Console.ReadLine()); 
            int number2 = Convert.ToInt32(Console.ReadLine()); 
            int number3 = Convert.ToInt32(Console.ReadLine()); 

            // Check if number1 is a palindrome
            bool isPalindrome1 = NumberChecker3.IsPalindrome(number1);
            Console.WriteLine($"{number1} is a palindrome: {isPalindrome1}");

            // Check if number2 is a palindrome
            bool isPalindrome2 = NumberChecker3.IsPalindrome(number2);
            Console.WriteLine($"{number2} is a palindrome: {isPalindrome2}");

            // Check if number3 is a palindrome
            bool isPalindrome3 = NumberChecker3.IsPalindrome(number3);
            Console.WriteLine($"{number3} is a palindrome: {isPalindrome3}");

            // Check if number1 is a duck number
            bool isDuck1 = NumberChecker3.IsDuckNumber(number1);
            Console.WriteLine($"{number1} is a duck number: {isDuck1}");

            // Check if number2 is a duck number
            bool isDuck2 = NumberChecker3.IsDuckNumber(number2);
            Console.WriteLine($"{number2} is a duck number: {isDuck2}");

            // Check if number3 is a duck number
            bool isDuck3 = NumberChecker3.IsDuckNumber(number3);
            Console.WriteLine($"{number3} is a duck number: {isDuck3}");
        }
    }
}

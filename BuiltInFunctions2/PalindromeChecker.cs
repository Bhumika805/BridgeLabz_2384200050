using System;

namespace BuiltInFunctions2
{
    public class PalindromeChecker
    {
        public void InputMethod()
        {
            Console.WriteLine("Enter a string to check if it's a palindrome:");
            string? input = Console.ReadLine();
			
			 if (string.IsNullOrEmpty(input))
			{
				return; // Or true, depending on how you want to handle empty input
			}
            bool isPalindrome = CheckPalindrome(input);
            DisplayResult(input, isPalindrome);
        }

        private bool CheckPalindrome(string? str)
        {
			 if (string.IsNullOrEmpty(str))
			{
				return false; // Or true, depending on how you want to handle empty input
			}
            str = str.ToLower();
            int len = str.Length;
            for (int i = 0; i < len / 2; i++)
            {
                if (str[i] != str[len - i - 1]) return false;
            }
            return true;
        }

        private void DisplayResult(string str, bool isPalindrome)
        {
            Console.WriteLine(isPalindrome ? $"{str} is a palindrome." : $"{str} is not a palindrome.");
        }
    }
}

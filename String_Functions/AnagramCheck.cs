using System;

namespace String_Functions
{
    class AnagramCheck
    {
        public void CheckAnagram()
        {
            Console.Write("Enter the first string: ");
            string? str1 = Console.ReadLine()?.Trim();

            Console.Write("Enter the second string: ");
            string? str2 = Console.ReadLine()?.Trim();
			
			if (string.IsNullOrWhiteSpace(str1) || string.IsNullOrWhiteSpace(str2) )
            {
                Console.WriteLine("No Value Provided.");
                return;
            }

            // If lengths of the strings are different, they cannot be anagrams
            if (str1.Length != str2.Length)
            {
                Console.WriteLine("The strings are not anagrams.");
                return;
            }

            // Convert both strings to character arrays and sort them
            char[] arr1 = str1.ToCharArray();
            char[] arr2 = str2.ToCharArray();

            Array.Sort(arr1);
            Array.Sort(arr2);

            // Compare the sorted arrays
            bool isAnagram = true;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    isAnagram = false;
                    break;
                }
            }

            // Output the result
            if (isAnagram)
            {
                Console.WriteLine("The strings are anagrams.");
            }
            else
            {
                Console.WriteLine("The strings are not anagrams.");
            }
        }
    }
}

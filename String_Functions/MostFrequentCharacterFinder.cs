using System;

namespace String_Functions
{
    class MostFrequentCharacterFinder
    {
        public void FindMostFrequentChar()
        {
            Console.Write("Enter a string: ");
            string? words = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(words))
            {
                Console.WriteLine("No Value Provided.");
                return;
            }

            int n = words.Length;
            char mostFrequentChar = '\0';  // Corrected: Use char, not int
            int maxCount = 0;
            
            for (int i = 0; i < n; i++)
            {
                int count = 0;

                // Count occurrences of words[i] in the entire string
                for (int j = 0; j < n; j++)
                {
                    if (words[i] == words[j])
                    {
                        count++;
                    }
                }

                // Update most frequent character if a higher count is found
                if (count > maxCount)
                {
                    maxCount = count;
                    mostFrequentChar = words[i];  // Directly assign the char
                }
            }

            if (mostFrequentChar == '\0')
            {
                Console.WriteLine("No alphabetic character found in the string.");
            }
            else
            {
                Console.WriteLine($"Most Frequent Character: '{mostFrequentChar}' (appeared {maxCount} times)");
            }
        }
    }
}

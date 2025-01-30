using System;

namespace String_Functions
{
    class WordReplace
    {
        public void ReplaceWordInSentence()
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine()?.Trim();

            Console.Write("Enter the word to replace: ");
            string wordToReplace = Console.ReadLine()?.Trim();

            Console.Write("Enter the word to replace it with: ");
            string replacementWord = Console.ReadLine()?.Trim();

            // Create a variable to store the new sentence after replacement
            string result = "";
            string[] words = sentence.Split(' '); // Split sentence into words

            // Loop through each word in the sentence
            foreach (string word in words)
            {
                if (word.Equals(wordToReplace, StringComparison.OrdinalIgnoreCase))
                {
                    result += replacementWord + " "; // Replace word
                }
                else
                {
                    result += word + " "; // Keep the original word
                }
            }

            // Output the result
            Console.WriteLine($"Modified Sentence: \"{result.Trim()}\"");
        }
    }
}

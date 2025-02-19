using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Collections
{
   class WordFrequencyCounter
    {
        public static Dictionary<string, int> CountWordFrequency(string filePath)
        {
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found!");
                return wordCount;
            }

            string text = File.ReadAllText(filePath).ToLower(); // Read file & convert to lowercase
            string[] words = Regex.Split(text, @"\W+"); // Split words by non-word characters

            foreach (string word in words)
            {
                if (string.IsNullOrWhiteSpace(word)) continue; // Skip empty entries

                if (wordCount.ContainsKey(word))
                    wordCount[word]++;
                else
                    wordCount[word] = 1;
            }

            return wordCount;
        }

        public void DisplayFrequencywords()
        {
            string filePath = "sample.txt"; // Change this to your actual file path
            Dictionary<string, int> wordFrequencies = CountWordFrequency(filePath);

            Console.WriteLine("Word Frequencies:");
            foreach (var entry in wordFrequencies.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
        }
    }

}

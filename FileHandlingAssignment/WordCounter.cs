using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FileHandlingAssignment
{
    class WordCounter
    {
        public void CountWordsInFile(string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    Console.WriteLine("Error: The specified file does not exist.");
                    return;
                }

                Dictionary<string, int> wordCount = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        // Remove punctuation and split words
                        string[] words = Regex.Replace(line, @"[^\w\s]", "").ToLower().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                        foreach (string word in words)
                        {
                            if (wordCount.ContainsKey(word))
                                wordCount[word]++;
                            else
                                wordCount[word] = 1;
                        }
                    }
                }

                // Display total word count
                int totalWords = wordCount.Values.Sum();
                Console.WriteLine($"\nTotal Words: {totalWords}");

                // Get top 5 most frequent words
                var topWords = wordCount.OrderByDescending(w => w.Value).Take(5);

                Console.WriteLine("\nTop 5 Most Frequent Words:");
                foreach (var word in topWords)
                {
                    Console.WriteLine($"{word.Key}: {word.Value} times");
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Error: File not found.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error reading file: " + ex.Message);
            }
        }

        static void Main()
        {
            WordCounter counter = new WordCounter();
            Console.Write("Enter the file path: ");
            string filePath = Console.ReadLine();
            counter.CountWordsInFile(filePath);
        }
    }

}

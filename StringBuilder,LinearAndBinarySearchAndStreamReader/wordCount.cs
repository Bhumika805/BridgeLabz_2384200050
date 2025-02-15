using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder_LinearAndBinarySearchAndStreamReader
{
     public class wordCount
     {
        public void wordcount()
        {
            string filePath = "C:\\Users\\91870\\Desktop\\New folder (5)/Testing.txt"; // Change to your actual file path
            string wordToFind = "hello";    // Change to the word you want to search
            int Count = 0;

            try
            {

                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] words = line.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (string word in words)
                        {
                            if (word.Equals(wordToFind)) Count++;
                        }
                    }
                }
                Console.WriteLine($"The word '{wordToFind}' appears {Count} times in the files");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file: {ex.Message}");
            }
        }
     }
}

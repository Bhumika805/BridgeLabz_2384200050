using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder_LinearAndBinarySearchAndStreamReader
{
    internal class FindSentence
    {

        public  void InputMethod()
        {
            string[] sentences =
            {
            "I am currently doing a .NET and C# internship at BridgeLabz.",
            "Previously, I completed a Java Development Internship at Internship Studio.",
            "I developed a Tourism Management System integrating hotel, vehicle, and food services.",
            "My University Management System project improved administrative efficiency in colleges.",
            "I have experience with Core Java, C#, .NET, MySQL, and full-stack development."
        };

            Console.Write("Enter a word to search for: ");
            string searchWord = Console.ReadLine();

            string foundSentence = FindSentenceContainingWord(sentences, searchWord);

            if (foundSentence != null)
                Console.WriteLine($"First sentence containing '{searchWord}': {foundSentence}");
            else
                Console.WriteLine($"No sentence contains the word '{searchWord}'.");
        }

        static string FindSentenceContainingWord(string[] sentences, string word)
        {
            foreach (string sentence in sentences) // Linear Search
            {
                if (sentence.IndexOf(word, StringComparison.OrdinalIgnoreCase) >= 0)
                    return sentence; // Return the first matching sentence
            }
            return null; // Return null if no match is found
        }
    }

}


using System;

namespace String_Functions
{
    class Longest_word
    {
        public void Longest()
        {
			Console.WriteLine("Enter the Sentence: ");
            string? input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("No Value Provided.");
                return;
            }
			
			char[] delimiters = {' ', '.', ',', '!', '?', ';', ':'};
			string[] words = input.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
			
			string longestword = "";
			int maxLength = 0;
			
			foreach(string word in words)
			{
				if(word.Length > maxLength)
				{
					maxLength = word.Length;
					longestword  = word;
				}
		    }
			
			Console.WriteLine($"The longest word in the sentence is: \"{longestword}\"");
		}
	}
}

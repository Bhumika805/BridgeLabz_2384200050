using System;

namespace String_Functions
{
	class CountVowel_CountConsonent
	{
		public void Counter()
		{
			Console.WriteLine("Enter a string or type (exit) to stop");
			string? input = Console.ReadLine();
				
			int vowelCount =0, consonentCount =0;
			
			if(string.IsNullOrEmpty(input))
			{
				Console.WriteLine("No Value Provided.");
				return;
			}
			
			input =input?.ToLower();
			for(int i =0; i< input.Length; i++)
			{
				char ch = input[i];
				
				if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' ||
                     ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
				{
					vowelCount++;
				}
				else
				{
					consonentCount++;
				}
			}
			
			
			Console.WriteLine($"Vowels: {vowelCount} and Consonents: {consonentCount}\n");
		}
	}
}
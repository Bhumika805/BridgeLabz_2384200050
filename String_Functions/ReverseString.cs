using System;

namespace String_Functions
{
	class ReverseString
	{
		public void Reverse()
		{
			Console.WriteLine("Enter the String.");
			string? input = Console.ReadLine();
			
			string rev ="";
			if(string.IsNullOrEmpty(input))
			{
				Console.WriteLine("No Value Provided.");
				return;
			}
			
			for(int i = input.Length - 1; i >= 0; i--)
			{
				rev +=input[i];
			}
			Console.WriteLine($"Reverse String is {rev}");
		}
	}
}
			
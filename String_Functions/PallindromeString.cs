using System;

namespace String_Functions
{
	class PallindromeString
	{
		public void Pallindrome()
		{
			Console.WriteLine("Enter the String: ");
			string? input = Console.ReadLine();
			
			string str = "";
			if(string.IsNullOrEmpty(input))
			{
				Console.WriteLine("No Value Provided.");
				return;
			}
			
			 for(int i=input.Length - 1; i>=0; i--)
			 {
				str += input[i];
			 }
			 if(str == input)
			 {
				Console.WriteLine($"String is Pallindrome {str}");
			 }
			 else
			 {
				Console.WriteLine($"String is not Pallindrome {str}");
			 }
		}
	}
}
				
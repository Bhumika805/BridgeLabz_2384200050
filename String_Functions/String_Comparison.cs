using System;

namespace String_Functions
{
	class String_Comparison
	{
		public void StringCompare()
		{
			Console.Write("Enter String1: ");
			string? str1 = Console.ReadLine();
			
			Console.Write("Enter String2: ");
			string? str2 = Console.ReadLine();
			

            if (string.IsNullOrWhiteSpace(str1))
            {
                Console.WriteLine("No Value Provided.");
                return;
            }
			
			if (string.IsNullOrWhiteSpace(str2))
            {
                Console.WriteLine("No Value Provided.");
                return;
            }
			
			int result;
			int length = Math.Min(str1.Length, str2.Length);
			
			if(str1.Length < str2.Length)
				Console.WriteLine($"\"{str1}\" comes before \"{str2}\" in lexicographical order.");
			else 
				Console.WriteLine($"\"{str2}\" comes before \"{str1}\" in lexicographical order.");
			
		}
	}
}
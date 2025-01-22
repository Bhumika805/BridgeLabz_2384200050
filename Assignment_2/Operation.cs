using System;

namespace Assignment_2
{
	class Operation
	{
		public void operations()
		{
			// Input: Take a, b, and c as integers from the user
			Console.Write("Enter value for a: ");
			int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter value for b: ");
			int b = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Enter value for c: ");
			int c = Convert.ToInt32(Console.ReadLine());

            // Compute the operations
			int result1 = a + b * c;          // Multiplication has higher precedence than addition
			int result2 = a * b + c;          // Multiplication first, then addition
			int result3 = c + a / b;          // Division first, then addition
			int result4 = a % b + c;          // Modulus first, then addition

            // Output: Print the results
			Console.WriteLine($"The results of Int Operations are:");
			Console.WriteLine($"1. a + b * c = {result1}");
			Console.WriteLine($"2. a * b + c = {result2}");
			Console.WriteLine($"3. c + a / b = {result3}");
			Console.WriteLine($"4. a % b + c = {result4}");
		}
    }    
}

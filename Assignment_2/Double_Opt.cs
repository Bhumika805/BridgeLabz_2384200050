using System;

namespace Assignment_2
{
	class Double_Opt
	{
		public void Doubleopt()
		{
			// Input: Take a, b, and c as double from the user
			Console.Write("Enter value for a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter value for b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter value for c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            // Compute the operations
            double result1 = a + b * c; // Multiplication has higher precedence than addition
            double result2 = a * b + c; // Multiplication first, then addition
            double result3 = c + a / b; // Division first, then addition
            double result4 = a % b + c; // Modulus first, then addition

            // Output: Print the results
            Console.WriteLine($"The results of Double Operations are:");
            Console.WriteLine($"1. a + b * c = {result1}");
            Console.WriteLine($"2. a * b + c = {result2}");
            Console.WriteLine($"3. c + a / b = {result3}");
            Console.WriteLine($"4. a % b + c = {result4}");
        }
    }
}

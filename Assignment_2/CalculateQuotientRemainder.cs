using System;

namespace Assignment_2
{
    class CalculateQuotientRemainder
    {
		public void num()
		{
			// Input: Take two numbers from the user
			Console.Write("Enter the first number: ");
			int number1 = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Enter the second number: ");
			int number2 = Convert.ToInt32(Console.ReadLine());

            // Calculation
			int quotient = number1 / number2;  // Division operator for quotient
			int remainder = number1 % number2; // Modulus operator for remainder

            // Output: Print the results
			Console.WriteLine($"The Quotient is {quotient} and Remainder is {remainder} of two numbers {number1} and {number2}");
		}
    }
}

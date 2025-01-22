using System;

namespace Assignment_2
{
	class Number_Swapper
	{
		public void SwapNumbers()
		{
			// Input: Take two numbers from the user
			Console.Write("Enter the first number: ");
			int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
			int number2 = Convert.ToInt32(Console.ReadLine());

            // Display original values
		    Console.WriteLine($"Before swapping: number1 = {number1}, number2 = {number2}");

            // Swap the numbers
            int temp = number1; // Temporary variable to hold number1
            number1 = number2;  // Assign number2 to number1
            number2 = temp;     // Assign temp (original number1) to number2

            // Output: Display swapped values
            Console.WriteLine($"After swapping: number1 = {number1}, number2 = {number2}");
		}
    }
}

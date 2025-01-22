using System;

namespace Assignment_2
{
	class Temperature2
	{
		public void temp_Celsius()
		{
			// Input: Take temperature in Celsius from the user
            Console.Write("Enter the temperature in Fahrenheit: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            // Formula: Convert Fahrenheit to Celsius
            double celsiusResult = (fahrenheit - 32) * 5 / 9;

           // Output: Print the result
           Console.WriteLine($"The {fahrenheit} Fahrenheit is {celsiusResult} Celsius.");
		}
    }
}

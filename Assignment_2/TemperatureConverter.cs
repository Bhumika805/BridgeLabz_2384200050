using System;

namespace Assignment_2
{
	class TemperatureConverter
	{
		public void temperature()
		{
			// Input: Take temperature in Celsius from the user
            Console.Write("Enter the temperature in Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            // Formula: Convert Celsius to Fahrenheit
            double fahrenheitResult = (celsius * 9 / 5) + 32;

           // Output: Print the result
           Console.WriteLine($"The {celsius} Celsius is {fahrenheitResult} Fahrenheit.");
		}
    }
}

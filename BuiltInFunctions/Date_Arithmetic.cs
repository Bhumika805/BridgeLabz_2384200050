using System;

namespace BuiltInFunctions
{
	class Date_Arithmetic
	{
		public void DateArithmetic()
		{
			// Get user input for a date
			Console.Write("Enter a date (yyyy-MM-dd): ");
			DateTime inputDate;
			
			while (!DateTime.TryParse(Console.ReadLine(), out inputDate))
				{
					Console.Write("Invalid format. Please enter a valid date (yyyy-MM-dd): ");
				}
				
				// Add 7 days, 1 month, and 2 years
				DateTime modifiedDate = inputDate.AddDays(7).AddMonths(1).AddYears(2);
				Console.WriteLine("Date after adding 7 days, 1 month, and 2 years: " + modifiedDate.ToString("yyyy-MM-dd"));
        
				// Subtract 3 weeks (21 days)
				DateTime finalDate = modifiedDate.AddDays(-21);
				Console.WriteLine("Final date after subtracting 3 weeks: " + finalDate.ToString("yyyy-MM-dd"));
		}
    }
}

		
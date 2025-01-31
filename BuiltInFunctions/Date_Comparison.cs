using System;

namespace BuiltInFunctions
{
	class Date_Comparison
	{
		public void DateComparison()
		{
			// Get first date input from user
			Console.Write("Enter the first date (yyyy-MM-dd): ");
			string firstDateString = Console.ReadLine();
			Console.Write("Enter the year: ");
				int firstYear = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter the month: ");
			int firstMonth = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter the day: ");
			int firstDay = Convert.ToInt32(Console.ReadLine());
			DateTime firstDate = new DateTime(firstYear, firstMonth, firstDay);
        
			// Get second date input from user
			Console.Write("Enter the second date (yyyy-MM-dd): ");
			string secondDateString = Console.ReadLine();
			Console.Write("Enter the year: ");
			int secondYear = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter the month: ");
			int secondMonth = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter the day: ");
			int secondDay = Convert.ToInt32(Console.ReadLine());
			DateTime secondDate = new DateTime(secondYear, secondMonth, secondDay);
        
			// Compare the two dates
			int comparison = firstDate.CompareTo(secondDate);
        
			if (comparison < 0)
			{
				Console.WriteLine("The first date is before the second date.");
			}
			else if (comparison > 0)
			{
				Console.WriteLine("The first date is after the second date.");
			}
			else
			{
				Console.WriteLine("Both dates are the same.");
			}
		}
    }
}


using System;

namespace BuiltInFunctions
{
	class Date_Formatting
	{
		public void DateFormatting()
		{
			// Get current date
			DateTime currentDate = DateTime.Now;
        
			// Display date in different formats
			Console.WriteLine("Date in dd/MM/yyyy format: " + currentDate.ToString("dd/MM/yyyy"));
			Console.WriteLine("Date in yyyy-MM-dd format: " + currentDate.ToString("yyyy-MM-dd"));
			Console.WriteLine("Date in EEE, MMM dd, yyyy format: " + currentDate.ToString("ddd, MMM dd, yyyy"));
		}
    }
}

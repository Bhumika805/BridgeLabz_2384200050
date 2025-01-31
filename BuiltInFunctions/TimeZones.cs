using System;

namespace BuiltInFunctions
{
	class TimeZones
	{
		public void Time__Zones()
		{
			// Get current UTC time
			DateTimeOffset utcNow = DateTimeOffset.UtcNow;
			Console.WriteLine("UTC Time: " + utcNow);
        
			// Convert to GMT (which is the same as UTC)
			TimeZoneInfo gmtZone = TimeZoneInfo.FindSystemTimeZoneById("GMT");
			DateTimeOffset gmtTime = TimeZoneInfo.ConvertTime(utcNow, gmtZone);
			Console.WriteLine("GMT Time: " + gmtTime);
        
			// Convert to IST (Indian Standard Time, UTC+5:30)
			TimeZoneInfo istZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
			DateTimeOffset istTime = TimeZoneInfo.ConvertTime(utcNow, istZone);
			Console.WriteLine("IST Time: " + istTime);
        
			// Convert to PST (Pacific Standard Time, UTC-8:00)
			TimeZoneInfo pstZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
			DateTimeOffset pstTime = TimeZoneInfo.ConvertTime(utcNow, pstZone);
			Console.WriteLine("PST Time: " + pstTime);
		}
		
	}
}

using System; 
 
namespace PracticeProblem2 
{ 
    class LeapYear 
    { 
        public void LeapYearChecker() 
        { 
            Console.Write("Enter a year (>= 1582): "); 
             
            // Read user input and convert it to an integer 
            int year = Convert.ToInt32(Console.ReadLine()); 
             
            // Check if the year is within the Gregorian calendar range 
            if (year < 1582) 
            { 
                Console.WriteLine("The year must be 1582 or later (Gregorian calendar)."); 
            } 
            else 
            { 
			// **Approach 1: Using Multiple If-Else Statements** 
				if (year % 4 == 0) 
				{ 
					if (year % 100 == 0) 
					{ 
						if (year % 400 == 0) 
						{ 
							Console.WriteLine($"{year} is a Leap Year (Approach 1)."); 
						} 
						else 
						{ 
							Console.WriteLine($"{year} is not a Leap Year (Approach 1)."); 
						} 
					} 
					else 
					{ 
						Console.WriteLine($"{year} is a Leap Year (Approach 1)."); 
					} 
				} 
				else 
				{ 
					Console.WriteLine($"{year} is not a Leap Year (Approach 1)."); 
				} 
				
					// **Approach 2: Using Single If Statement with Logical Operators** 
				if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0) 
				{ 
					Console.WriteLine($"{year} is a Leap Year (Approach 2)."); 
				} 
				else 
				{ 
					Console.WriteLine($"{year} is not a Leap Year (Approach 2)."); 
				} 
			} 
		} 
	} 
}
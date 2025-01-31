using System ;

namespace BuiltInFunctions
{
	class Program
	{
		static void Switch_Case()
		{
			Console.WriteLine("Eneter the Question Number:");
			int choice = Convert.ToInt32(Console.ReadLine());
			
			
			
			switch(choice)
			{
				case 1:
					TimeZones obj1 = new TimeZones();
					obj1.Time__Zones();
					break;
					
				case 2:
					Date_Arithmetic obj2 = new Date_Arithmetic();
					obj2.DateArithmetic();
					break;	
					
				case 3:
					Date_Formatting obj3 = new Date_Formatting();
					obj3.DateFormatting();
					break;

				case 4:
					Date_Comparison obj4 = new Date_Comparison();
					obj4.DateComparison();
					break;	
					
				case 5:
				    Console.WriteLine("Existing the Preogram...");
					break;
					
				default :
				    Console.WriteLine("Invalid Choice Please Enter the Valid Choice. ");
					break;
					
			}
		}
		
		static void Main (string[] args)
		{
			Switch_Case();
		}
		
	}
}
			
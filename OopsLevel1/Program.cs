using System;

namespace OOPSLevel1
{
	class Program
	{
		static void Switchcases()
		{
	
			Console.WriteLine("Enter which question you want to run (1 to 3):");
			int ques = Convert.ToInt32(Console.ReadLine());

			switch (ques)
			{
				case 1:
				Employee obj1 = new Employee();
				obj1.InputDetails();
				obj1.DisplayDetails();
				break;
			case 2:
				Circle obj2 = new Circle();
				obj2.InputRadius();
				obj2.DisplayDetails();
				break;
			case 3:
				Book obj3 = new Book();
				obj3.InputDetails();
				obj3.DisplayDetails();
				break;
			default:
				Console.WriteLine("Invalid question number. Please select between 1 and 3.");
				break;
			}
		}
		static void Main(string[] args)
		{
				Switchcases();
		}
	}
}
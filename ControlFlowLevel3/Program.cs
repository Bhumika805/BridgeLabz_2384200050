using System;

namespace ControlFlowLevel3
{
    class Program
    {
		static void Switch_cases(){
			
			Console.WriteLine("Enter The Question Number");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ArmstrongNumber Obj1 = new ArmstrongNumber();
                    Obj1.ArmstrongNum();
                    break;
					
				case 2:
				    CountDigits obj2 = new CountDigits();
				    obj2.CountDigitsInNumber();
				    break;
					
				case 3:
				    HarshadNumber obj3 = new HarshadNumber();
				    obj3.CheckHarshadNumber();
				    break;
					
				case 4:
				    AbundantNumber obj4 = new AbundantNumber();
				    obj4.CheckAbundantNumber();
				    break;
					
				case 5:
				    Calculator obj6 = new Calculator();
				    obj6.CalcOperation();
				    break;
					
				case 6:
				    Console.WriteLine("Exiting the program...");
				    break;
					
				default:
                    Console.WriteLine("Invalid question number. Please select valid choice.");
                    break;
            }
		}
        static void Main(string[] args)
        {
            Switch_cases();
        }
    }
}
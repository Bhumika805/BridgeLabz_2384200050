using System;

namespace ControlFlowLevel2
{
    class Program
    {
		static void Switch_cases(){
			
			Console.WriteLine("Enter The Question Number : 1 to 12");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    LeapYear Obj1 = new LeapYear();
                    Obj1.LeapYearChecker();
                    break;
					
				case 2:
                    GradeCalculator Obj2 = new GradeCalculator();
                    Obj2.Grading();
                    break;
					
				case 3:
                    PrimeNumberCheck Obj3 = new PrimeNumberCheck();
                    Obj3.PrimeNumber();
                    break;
					
				case 4:
                    FizzBuzzProgram Obj4 = new FizzBuzzProgram();
                    Obj4.FizzBuzz();
                    break;
					
				case 5:
                    FizzBuzzProgram2 Obj5 = new FizzBuzzProgram2();
                    Obj5.FizzBuzz2();
                    break;
					
				case 6:
                    BMI_Calculator Obj6 = new BMI_Calculator();
                    Obj6.BMI_Calculation();
                    break;
					
				case 7:
                    GreatestFactor Obj7 = new GreatestFactor();
                    Obj7.Greatest_Factor();
                    break;
					
				case 8:
                    Factor Obj8 = new Factor();
                    Obj8.greatest_Factor();
                    break;
					
				case 9:
                    PowerCalculator Obj9 = new PowerCalculator();
                    Obj9.Calculation();
                    break;
					
				case 10:
                    FactorsFinder Obj10 = new FactorsFinder();
                    Obj10.Factor__Finder();
                    break;
					
				case 11:
                    MultiplesFinder Obj11 = new MultiplesFinder();
                    Obj11.Multiple__Finder();
                    break;
					
				case 12:
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
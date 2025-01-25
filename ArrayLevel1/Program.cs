using System;

namespace ArrayLevel1
{
    class Program
    {
		static void Switch_cases(){
			
			Console.WriteLine("Enter The Question Number");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    StudentVoting Obj1 = new StudentVoting();
                    Obj1.AgeOfStudent();
                    break;
					
				case 2:
				    CheckNum obj2 = new CheckNum();
				    obj2.NumberCheck();
				    break;
					
				case 3:
				    MultiplicationTable obj3 = new MultiplicationTable();
				    obj3.Table();
				    break;
					
				case 4:
				    MultipleValues obj4 = new MultipleValues();
				    obj4.Multiple__Value();
				    break;
					
				case 5:
				    Multiplication obj5 = new Multiplication();
				    obj5.Tables();
				    break;
					
				case 6:
				    FootballTeam obj6 = new FootballTeam();
				    obj6.Team_Football();
				    break;
					
				case 7:
				    OddEvenArrays obj7 = new OddEvenArrays();
				    obj7.CheckOddEvenArrays();
				    break;
					
				case 8:
				    FactorFinder obj8 = new FactorFinder();
				    obj8.Factor__Finder();
				    break;
					
				case 9:
				    MultiDimensionalArray obj9 = new MultiDimensionalArray();
				    obj9.DimensionalArray();
				    break;
					
				case 10:
				    FizzBuzzProgram obj10 = new FizzBuzzProgram();
				    obj10.FizzBuzz();
				    break;
					
				case 11:
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
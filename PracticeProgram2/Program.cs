using System;

namespace PracticeProblem2
{
    class Program
    {
		static void Switch_cases(){
			
			Console.WriteLine("Enter The Question Number");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice){
                case 1:
                    // Create an instance of the class and call the method
					FactorsOfNumber obj1 = new FactorsOfNumber();
					obj1.DisplayFactorsResult();
                    break;
	
				
				case 2:
					RecursiveSum obj2 = new RecursiveSum();
					obj2.NaturalNumber();
				    break;
					
				case 3:
				    LeapYear obj3 = new LeapYear();
				    obj3.LeapYearChecker();
				    break;
					
				case 4:
					Convertor.Converson();
				    break;
					
				case 5:
					UnitConvertor.PrintConversions();
					break;
					
				case 6:
				    StudentVote__Checker obj6 = new StudentVote__Checker();
				    obj6.StudentVote();
				    break;
					
				case 7:
				    FriendComparisonApp obj7 = new FriendComparisonApp();
				    obj7.ComparisonApp();
				    break;
					
				case 8:
				    NumberAnalysis analysis = new NumberAnalysis();
					analysis.Analysation();
				    break;
					
				case 9:
					BMIProgram program = new BMIProgram();
					program.RunBMIProgram();
				    break;
					
				case 10:
				    QuadraticEquation obj10 = new QuadraticEquation();
				    obj10.Quadratic__Equation();
				    break;
					
				case 11:
				    UnitConversionUtility obj11 = new UnitConversionUtility();
				    obj11.ConversionUtility();
				    break;
					
				case 12:
				    RandomNumberAnalysis obj12 = new RandomNumberAnalysis();
				    obj12.RandomNum_Analysis();
				    break;
					
				case 13:
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
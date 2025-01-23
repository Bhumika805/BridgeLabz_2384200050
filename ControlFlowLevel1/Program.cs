using System;

namespace ControlFlowLevel1
{
    class Program
    {
		static void Switch_cases(){
			
			Console.WriteLine("Enter The Question Number");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CheckNumber Obj1 = new CheckNumber();
                    Obj1.num();
                    break;
					
				case 2:
				    SmallestNumberChecker obj2 = new SmallestNumberChecker();
				    obj2.SmallestNumber();
				    break;
					
				case 3:
				    LargestNumberChecker obj3 = new LargestNumberChecker();
				    obj3.LargestNumber();
				    break;
					
				case 4:
				    NaturalNumberSum obj4 = new NaturalNumberSum();
				    obj4.CalculateSum();
				    break;
					
				case 5:
				    VotingEligibility obj5 = new VotingEligibility();
				    obj5.CheckVotingEligibility();
				    break;
					
				case 6:
				    NumberCheck obj6 = new NumberCheck();
				    obj6.CheckNumber();
				    break;
					
				case 7:
				    RocketLaunchCountdown obj7 = new RocketLaunchCountdown();
				    obj7.RocketLaunch();
				    break;
					
				case 8:
				    RocketLaunchCountdown2 obj8 = new RocketLaunchCountdown2();
				    obj8.RocketLaunch2();
				    break;
					
				case 9:
				    SumUntilZero obj9 = new SumUntilZero();
				    obj9.SumZero();
				    break;
					
				case 10:
				    SumUntilZeroOrNegative obj10 = new SumUntilZeroOrNegative();
				    obj10.SumUntilZero___Negative();
				    break;
					
				case 11:
				    NaturalNumber obj11 = new NaturalNumber();
				    obj11.NaturalNumberSum();
				    break;
					
				case 12:
				    NumberSum obj12 = new NumberSum();
				    obj12.Numbers();
				    break;
					
				case 13:
				    FactorialProgram obj13 = new FactorialProgram();
				    obj13.Factorial();
				    break;
					
				case 14:
				    FactorialProgram2 obj14 = new FactorialProgram2();
				    obj14.Factorial2();
				    break;
					
				case 15:
				    OddEvenProgram obj15 = new OddEvenProgram();
				    obj15.OddEven();
				    break;
					
				case 16:
				    BonusAmount obj16 = new BonusAmount();
				    obj16.Bonus();
				    break;
					
				case 17:
				    MultiplicationTable obj17 = new MultiplicationTable();
				    obj17.Multiplication();
				    break;
					
				case 18:
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
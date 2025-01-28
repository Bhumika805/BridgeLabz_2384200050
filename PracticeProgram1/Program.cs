using System;

namespace PracticeProblem1
{
    class Program
    {
		static void Switch_cases(){
			
			Console.WriteLine("Enter The Question Number");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    // Create an instance of the class and call the method
					DisplaySimpleInterest obj = new DisplaySimpleInterest();
					obj.CalculateAndDisplaySimpleInterest();
                    break;
					
				case 2:
				    // Create an instance of HandshakeCalculator and call the method
					HandshakeCalculator calculator = new HandshakeCalculator();
					calculator.CalculateAndDisplayHandshakes();
				    break;
					
				case 3:
				    HandshakeProgram obj3 = new HandshakeProgram();
				    obj3.DisplayHandshakes();
				    break;
					
				case 4:
				    TriangularPark obj4 = new TriangularPark();
				    obj4.Triangular__Park();
				    break;
					
				case 5:
				    NumberCheck obj5 = new NumberCheck();
				    obj5.Number_Checker();
				    break;
					
				case 6:
				    SpringSeasonChecker obj6 = new SpringSeasonChecker();
				    obj6.SeasonChecker();
				    break;
					
				case 7:
				    SumOfNaturalNumbers obj7 = new SumOfNaturalNumbers();
				    obj7.SumOfNatural__Numbers();
				    break;
					
				case 8:
				    SmallestAndLargest obj8 = new SmallestAndLargest();
				    obj8.Smallest__Largest();
				    break;
					
				case 9:
				    ChocolateDivision obj9 = new ChocolateDivision();
				    obj9.Chocolate__Division();
				    break;
					
				case 10:
				    QuotientAndRemainder obj10 = new QuotientAndRemainder();
				    obj10.Quotient__Remainder();
				    break;
					
				case 11:
				    WindChillCalculator obj11 = new WindChillCalculator();
				    obj11.WindChill();
				    break;
					
				case 12:
				    TrigonometricFunctions obj12 = new TrigonometricFunctions();
				    obj12.Trigonometric__Functions();
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
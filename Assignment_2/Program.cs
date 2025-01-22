using System;

namespace Assignment_2
{
    class Program
    {
		static void Switch_cases(){
			
			Console.WriteLine("Enter The question which you want to run (1 to 13):");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CalculateQuotientRemainder Obj1 = new CalculateQuotientRemainder();
                    Obj1.num();
                    break;
					
				case 2:
				    Operation obj2 = new Operation();
				    obj2.operations();
				    break;
					
				case 3:
				    Double_Opt obj3 = new Double_Opt();
				    obj3.Doubleopt();
				    break;
					
				case 4:
				    TemperatureConverter obj4 = new TemperatureConverter();
				    obj4.temperature();
				    break;
					
				case 5:
				    Temperature2 obj5 = new Temperature2();
				    obj5.temp_Celsius();
				    break;
					
				case 6:
				    IncomeCalculator obj6 = new IncomeCalculator();
				    obj6.totalincomecalculator();
				    break;
					
				case 7:
				    Number_Swapper obj7 = new Number_Swapper();
				    obj7.SwapNumbers();
				    break;
					
				case 8:
				    JourneyDetails obj8 = new JourneyDetails();
				    obj8.GetJourneyDetails();
				    break;
					
				case 9:
				    Athlete_Rounds obj9 = new Athlete_Rounds();
				    obj9.Calculate_Rounds();
				    break;
					
				case 10:
				    Chocolates_Divider obj10 = new Chocolates_Divider();
				    obj10.Divide_Chocolate();
				    break;
					
				case 11:
				    Chocolates_Divider obj11 = new Chocolates_Divider();
				    obj11.Divide_Chocolate();
				    break;
					
				case 12:
				    Weight_Converter obj12 = new Weight_Converter();
				    obj12.Convert_Weight();
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
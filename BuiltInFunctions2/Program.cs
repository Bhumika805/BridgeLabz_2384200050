using System;

namespace BuiltInFunctions2
{
	class Program{
		static void Switchcases(){
	
			Console.WriteLine("Enter which question you want to run (1 to 9):");
			int ques = Convert.ToInt32(Console.ReadLine());

		switch (ques)
		{
        case 1:
            NumberGuessingGame obj1 = new NumberGuessingGame();
			obj1.StartGame();
            break;
		case 2:
			MaximumOfThree obj2 = new MaximumOfThree();
			obj2.InputMethod();
			break;
		case 3:
			PrimeNumberChecker obj3 = new PrimeNumberChecker();
			obj3.InputMethod();
			break;
		case 4:
		    FibonacciGenerator obj4 = new FibonacciGenerator();
			obj4.InputMethod();
			break;
		case 5:
			 PalindromeChecker obj5 = new PalindromeChecker();
			  obj5.InputMethod();
			break;
		case 6:
			FactorialCalculator obj6 = new FactorialCalculator();
			obj6.InputMethod();
			break;
		case 7:
			GCDLCMCalculator obj7 = new GCDLCMCalculator();
			obj7.InputMethod();
			break;
		case 8:
			TemperatureConverter obj8 = new TemperatureConverter();
			obj8.InputMethod();
			break;
		case 9:
			BasicCalculator obj9 = new BasicCalculator();
			obj9.InputMethod();
			break;
        default:
            Console.WriteLine("Invalid question number. Please select between 1 and 9.");
            break;
		}
	}
	static void Main(string[] args)
	{
    Switchcases();
	}
	}
}
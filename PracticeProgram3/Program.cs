using System;

namespace PracticeProblem3
{
	class Program{
		static void Switchcases(){
	
			Console.WriteLine("Enter which question you want to run (1 to 12):");
			int ques = Convert.ToInt32(Console.ReadLine());

		switch (ques)
		{
        case 1:
            FootballTeamHeightAnalyzer obj1 = new FootballTeamHeightAnalyzer();
			obj1.AnalyzeHeights();
            break;
		case 2:
			NumberChecker obj2 = new NumberChecker();
			obj2.Input();
			break;
		case 3:
			NumberChecker2 obj3 = new NumberChecker2();
			obj3.Input();
			break;
		case 4:
		    
			NumberChecker3 demo = new NumberChecker3();
            demo.Input();
			break;
		case 5:
		    NumberChecker4 demo = new NumberChecker4();
            demo.Input();
			break;
		case 6:
			NumberChecker5 demo = new NumberChecker5();
            demo.CheckAllNumberProperties();
			break;
		case 7:
			OTPUtility demo = new OTPUtility();
            demo.Input();
			break;
		case 8:
			CalendarUtility demo = new CalendarUtilitys();
            demo.Input();
			break;
		case 9:
			SlopeCalculation demo = new SlopeCalculation();
			demo.InputMethod();
			break;
		case 10:
			Triangle demo = new Triangle();
			demo.InputMethod();
			break;
		case 11:
			ZaraEmployeeBonus demo = new ZaraEmployeeBonus();
			demo.Input();
			break;
		case 12:
			StudentScoreCard demo = new StudentScoreCard();
			demo.InputMethod();
			break;
		case 13:
			MatrixOperations demo = new MatrixOperations();
			demo.InputMethod();
			break;
        default:
            Console.WriteLine("Invalid question number. Please select between 1 and 12.");
            break;
		}
	}
	static void Main(string[] args)
	{
    Switchcases();
	}
	}
}
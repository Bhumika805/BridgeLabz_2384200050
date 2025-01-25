using System;

namespace ArrayLevel2
{
    class Program
    {
		static void Switch_cases(){
			
			Console.WriteLine("Enter The Question Number");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ZaraBonusProgram Obj1 = new ZaraBonusProgram();
                    Obj1.BonusProgram();
                    break;
					
				case 2:
				    FriendsAgeHeight obj2 = new FriendsAgeHeight();
				    obj2.CheckFriendsAgeHeight();
				    break;
					
				case 3:
				    LargestSecondLargest obj3 = new LargestSecondLargest();
				    obj3.LargestElement();
				    break;
					
				case 4:
				    MaxDigit obj4 = new MaxDigit();
				    obj4.IncMaxDigit();
				    break;
					
				case 5:
				    ReverseNumber obj5 = new ReverseNumber();
				    obj5.ReverseOrder();
				    break;
					
				case 6:
				    BMI_Calculator obj6 = new BMI_Calculator();
				    obj6.CheckBMICalculator();
				    break;
					
				case 7:
				    MultiDimensional_BMI obj7 = new MultiDimensional_BMI();
				    obj7.BMI();
				    break;
					
				case 8:
				    StudentGradeCalculator obj8 = new StudentGradeCalculator();
				    obj8.GradeCalculator();
				    break;
					
				case 9:
				    StudentGradeCalculator2 obj9 = new StudentGradeCalculator2();
				    obj9.GradeCalculator2();
				    break;
					
				case 10:
				    DigitFrequency obj10 = new DigitFrequency();
				    obj10.Digit__Frequency();
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
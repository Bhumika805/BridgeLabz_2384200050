using System;

namespace Submission_of_Programming_Elements_Practices
{
    class Program
    {
		static void Switchcases(){
			
			Console.WriteLine("Enter which question you want to run (1 to 16):");
            int ques = Convert.ToInt32(Console.ReadLine());

            switch (ques)
            {
                case 1:
                    CalculateAge Obj1 = new CalculateAge();
                    Obj1.AgeCalculate();
                    break;

                case 2:
                    AvgPercentage Obj2 = new AvgPercentage();
                    Obj2.Avg();
                    break;
					
				case 3:
					KmtoMiles obj3 = new KmtoMiles();
					obj3.ConvertKmtoMiles();
					break;
				
				case 4:
					ProfitCalc obj4 = new ProfitCalc();
					obj4.CalculateProfit();
					break;
					
				case 5:
				    PenDis obj5 = new PenDis();
					obj5.Distribution();
					break;
				
				case 6:
					 DiscountCalc obj6 = new DiscountCalc();
					 obj6.CalculateFee();
					 break;
				
				case 7:
					 VolumeCalc obj7 = new VolumeCalc();
                     obj7.ComputeVolume();
					 break;
					
				case 8:
					KmtoMiles2 obj8 = new KmtoMiles2();
					obj8.ConvertKmtoMiles2();
					break;
				
				case 9:
					DiscountCalc2 obj9 = new DiscountCalc2();
					obj9.CalculateFee();
					break;
				
				case 10:
					HeightConvert obj10 = new HeightConvert();
					obj10.ConvertHeight();
					break;
				case 11:
					BasicCalc obj11 = new BasicCalc();
					obj11.PerformOperation();
					break;
				case 12:
					TriangleCalc obj12 = new TriangleCalc();
					obj12.CalculateArea();
					break;
				case 13:
					SquareSide obj13 = new SquareSide();
					obj13.CalcSide();
					break;
				case 14:
					YardandMiles obj14 = new YardandMiles();
					obj14.ConvertYardfromCm();
					break;
				case 15:
					CalcTotalPrice obj15 = new CalcTotalPrice();
					obj15.CalcPrice();
					break;
				case 16:
				    HandshakeCalculator obj16 = new HandshakeCalculator();
			        obj16.CalculateHandshakes();
				    break;
                default:
                    Console.WriteLine("Invalid question number. Please select between 1 and 16.");
                    break;
            }
		}
        static void Main(string[] args)
        {
            Switchcases();
        }
    }
}

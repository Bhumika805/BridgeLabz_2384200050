using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_This_sealed_is_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which Question do you want to Run 2 to 7");
            int ques = Convert.ToInt32(Console.ReadLine());
            CallingAllClass callingAllClass = new CallingAllClass();    

            switch (ques)
            {
                case 2:
                    callingAllClass.CallingLibrary();
                    break;
                case 3:
                    callingAllClass.CallingEmployee();
                    break;
                case 4:
                    callingAllClass.CallingShoppingCart();
                    break;
                case 5:
                    callingAllClass.CallingUniversity();
                    break;
                case 6:
                    callingAllClass.CallingVehicle();
                    break;
                case 7:
                    callingAllClass.CallingHospital();
                    break;
                default:
                    Console.WriteLine("Invalid Question number");
                    break;

            
            }
        }
    }
}

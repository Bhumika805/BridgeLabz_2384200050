using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsConcept
{
    class Program
    {
        static void SwitchCase()
        {
            Console.WriteLine("Enter the question number:");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Program1 warehouse = new Program1();
                    warehouse.ProgramMethod1();
                    break;


                default:
                    Console.WriteLine("Invalid Question Number...");
                    break;
            }

        }
        static void Main(string[] args)
        {
            SwitchCase();
        }
    }
}

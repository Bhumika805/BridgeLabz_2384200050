using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm
{
    internal class Program
    {
        public static void SwitchCase()
        {
            Console.WriteLine("Enter the Question Number (1 To 7)");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    BubbleSort bubbleSort = new BubbleSort();
                    bubbleSort.Method();
                    break;

                case 2:
                    EmployeeSorter sorter = new EmployeeSorter();
                    sorter.Employee_Method();
                    break;


                default:
                    Console.WriteLine("Invalid number. Please choose correct Number.");
                    break;

            }
        }
        static void Main(string[] args)
        {
            SwitchCase();
        }
    }
}

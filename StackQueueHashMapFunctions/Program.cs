using StackQueueHashMapFunctions.StackQueueHashMapFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueueHashMapFunctions
{
    internal class Program
    {
        static void Questions()
        {
            Console.WriteLine("Enter the choice:");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    QueueMethod queueMethod = new QueueMethod();
                    queueMethod.queueStacks();
                    break;

                case 2:
                    StackUsingRecursion recursion = new StackUsingRecursion();
                    recursion.Method();
                    break;

                case 3:
                    StockSpan stockSpan = new StockSpan();
                    stockSpan.Stock_Method();
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please choose valid option.");
                    break;
            }
        }

        static void Main(string[] args)
        {
            Questions();
        }
    }
}

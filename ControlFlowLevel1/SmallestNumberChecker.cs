using System;

namespace ControlFlowLevel1
{
    class SmallestNumberChecker
    {
        public void SmallestNumber()
        {
            Console.WriteLine("Enter the first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the third number: ");
            int number3 = Convert.ToInt32(Console.ReadLine());

            // Check if the first number is the smallest
            bool isSmallest = number1 < number2 && number1 < number3;

            // Output
            Console.WriteLine($"Is the first number the smallest? {isSmallest}");
        }
    }
}

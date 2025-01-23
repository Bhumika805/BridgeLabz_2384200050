using System;

namespace ControlFlowLevel1
{
    class LargestNumberChecker
    {
        public void LargestNumber()
        {
            Console.WriteLine("Enter the first number:");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the third number:");
            int number3 = Convert.ToInt32(Console.ReadLine());

            // Check which number is the largest
            bool isFirstLargest = (number1 > number2 && number1 > number3);
            bool isSecondLargest = (number2 > number1 && number2 > number3);
            bool isThirdLargest = (number3 > number1 && number3 > number2);

            // Output the results
            Console.WriteLine($"Is the first number the largest? {isFirstLargest}");
            Console.WriteLine($"Is the second number the largest? {isSecondLargest}");
            Console.WriteLine($"Is the third number the largest? {isThirdLargest}");
        }
    }
}

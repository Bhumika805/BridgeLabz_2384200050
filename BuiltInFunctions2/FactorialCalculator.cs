using System;

namespace BuiltInFunctions2
{
    public class FactorialCalculator
    {
        public void InputMethod()
        {
            Console.WriteLine("Enter a number to calculate factorial:");
            int num = Convert.ToInt32(Console.ReadLine());
            int result = CalculateFactorial(num);
            Console.WriteLine($"Factorial of {num} is {result}");
        }

        private int CalculateFactorial(int n)
        {
            return (n == 0 || n == 1) ? 1 : n * CalculateFactorial(n - 1);
        }
    }
}

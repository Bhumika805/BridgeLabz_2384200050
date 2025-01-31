using System;

namespace BuiltInFunctions2
{
    public class FibonacciGenerator
    {
        public void InputMethod()
        {
            Console.WriteLine("Enter the number of Fibonacci terms:");
            int terms = Convert.ToInt32(Console.ReadLine());
            GenerateFibonacci(terms);
        }

        private void GenerateFibonacci(int terms)
        {
            int a = 0, b = 1, temp;
            Console.WriteLine("Fibonacci Sequence:");
            for (int i = 0; i < terms; i++)
            {
                Console.Write(a + " ");
                temp = a + b;
                a = b;
                b = temp;
            }
            Console.WriteLine();
        }
    }
}

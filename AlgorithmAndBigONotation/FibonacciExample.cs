using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndBigONotation
{
    class FibonacciExample
    {
        // Recursive approach
        public static int FibonacciRecursive(int n)
        {
            if (n <= 1) return n;
            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }

        // Iterative approach
        public static int FibonacciIterative(int n)
        {
            int a = 0, b = 1, sum;
            for (int i = 2; i <= n; i++)
            {
                sum = a + b;
                a = b;
                b = sum;
            }
            return b;
        }

        // Main method to test the approaches
        public void Fibonacci()
        {
            int n = 30; // You can change this value to test with different Fibonacci numbers

            // Testing the recursive approach
            var startTime = DateTime.Now;
            int resultRecursive = FibonacciRecursive(n);
            var endTime = DateTime.Now;
            Console.WriteLine($"Recursive Fibonacci({n}) = {resultRecursive}");
            Console.WriteLine($"Time taken (Recursive): {endTime - startTime}");

            // Testing the iterative approach
            startTime = DateTime.Now;
            int resultIterative = FibonacciIterative(n);
            endTime = DateTime.Now;
            Console.WriteLine($"Iterative Fibonacci({n}) = {resultIterative}");
            Console.WriteLine($"Time taken (Iterative): {endTime - startTime}");
        }
    }

}

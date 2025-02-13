using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueueHashMapFunctions
{
    class StockSpan
    {
        // Function to calculate stock span using a manual stack
        public static void CalculateSpan(int[] prices, int[] span)
        {
            int n = prices.Length;
            int[] stack = new int[n]; // Manual stack to store indices
            int top = -1; // Stack pointer (initially empty)

            for (int i = 0; i < n; i++)
            {
                // Pop elements while stack is not empty and price at stack[top] <= current price
                while (top >= 0 && prices[stack[top]] <= prices[i])
                {
                    top--; // Remove elements from stack
                }

                // If stack is empty, all previous elements are smaller, so span = i + 1
                span[i] = (top == -1) ? (i + 1) : (i - stack[top]);

                // Push the current index onto the stack
                stack[++top] = i;
            }
        }

        public void Stock_Method()
        {
            // User input for stock prices
            Console.Write("Enter the number of stock prices: ");
            int n = int.Parse(Console.ReadLine());

            int[] prices = new int[n];
            int[] span = new int[n];

            Console.WriteLine("Enter stock prices:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Day {i + 1} price: ");
                prices[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Compute stock spans
            CalculateSpan(prices, span);

            // Display results manually without using string.Join
            Console.WriteLine("\nStock Prices:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(prices[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Stock Span:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(span[i] + " ");
            }
            Console.WriteLine();
        }
    }
}


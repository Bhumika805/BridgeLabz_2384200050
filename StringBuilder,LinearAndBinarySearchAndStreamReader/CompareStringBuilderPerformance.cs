using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder_LinearAndBinarySearchAndStreamReader
{
    internal class CompareStringBuilderPerformance
    {
        public void InputMethod()
        {
            int iterations = 10000; // Number of concatenations

            // Measure performance using String concatenation
            Stopwatch sw1 = Stopwatch.StartNew();
            string result1 = StringConcatenation(iterations);
            sw1.Stop();
            Console.WriteLine($"String Concatenation Time: {sw1.ElapsedMilliseconds} ms");

            // Measure performance using StringBuilder
            Stopwatch sw2 = Stopwatch.StartNew();
            string result2 = StringBuilderConcatenation(iterations);
            sw2.Stop();
            Console.WriteLine($"StringBuilder Concatenation Time: {sw2.ElapsedMilliseconds} ms");
        }

        static string StringConcatenation(int count)
        {
            string result = "";
            for (int i = 0; i < count; i++)
            {
                result += "Hello ";
            }
            return result;
        }

        static string StringBuilderConcatenation(int count)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                sb.Append("Hello ");
            }
            return sb.ToString();
        }
    }
}


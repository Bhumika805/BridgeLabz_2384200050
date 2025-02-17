using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace AlgorithmAndBigONotation
{

    class StringConcatenationComparison
    {
        public void StringConcatenation()
        {
            int[] sizes = { 1000, 10000, 1000000 }; // Different operation counts

            foreach (int size in sizes)
            {
                Console.WriteLine($"\nConcatenating {size} strings:");

                // Using string (O(N²)) - Skipping for large data to prevent long execution
                if (size <= 10000)
                {
                    Stopwatch swString = Stopwatch.StartNew();
                    ConcatenateUsingString(size);
                    swString.Stop();
                    Console.WriteLine($"String: {swString.ElapsedMilliseconds} ms");
                }
                else
                {
                    Console.WriteLine("String: Skipped (Too slow)");
                }

                // Using StringBuilder (O(N))
                Stopwatch swStringBuilder = Stopwatch.StartNew();
                ConcatenateUsingStringBuilder(size);
                swStringBuilder.Stop();
                Console.WriteLine($"StringBuilder: {swStringBuilder.ElapsedMilliseconds} ms");
            }
        }

        // String concatenation (O(N²))
        public void ConcatenateUsingString(int n)
        {
            string result = "";
            for (int i = 0; i < n; i++)
            {
                result += "x"; // Each step creates a new string in memory
            }
        }

        // StringBuilder concatenation (O(N))
        public void ConcatenateUsingStringBuilder(int n)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                sb.Append("x"); // Appends directly to the buffer
            }
        }
    }
}

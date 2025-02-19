using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class BinaryNumberGenerator
    {
        public static List<string> GenerateBinaryNumbers(int N)
        {
            List<string> result = new List<string>();
            Queue<string> queue = new Queue<string>();

            queue.Enqueue("1"); // Start with "1"

            for (int i = 0; i < N; i++)
            {
                string current = queue.Dequeue();
                result.Add(current);

                // Generate the next binary numbers and enqueue them
                queue.Enqueue(current + "0");
                queue.Enqueue(current + "1");
            }

            return result;
        }

        public void DisplayNumGenrator()
        {
            int N = 5;
            Console.WriteLine("Binary Numbers: " + string.Join(", ", GenerateBinaryNumbers(N)));
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace AlgorithmAndBigONotation
{
    class SearchComparison
    {
        public void Searching()
        {
            int[] sizes = { 1000, 10000, 1000000 };
            Random rand = new Random();

            foreach (int size in sizes)
            {
                RunSearchComparison(size, rand);
            }
        }

        public void RunSearchComparison(int size, Random rand)
        {
            int[] data = new int[size];
            for (int i = 0; i < size; i++)
                data[i] = rand.Next(1, size * 10);

            int target = data[rand.Next(size)]; // Pick a random target

            // Linear Search
            Stopwatch sw = Stopwatch.StartNew();
            LinearSearch(data, target);
            sw.Stop();
            Console.WriteLine($"Linear Search ({size} elements): {sw.ElapsedMilliseconds} ms");

            // Binary Search (requires sorting)
            Array.Sort(data);
            sw.Restart();
            BinarySearch(data, target);
            sw.Stop();
            Console.WriteLine($"Binary Search ({size} elements): {sw.ElapsedMilliseconds} ms\n");
        }

        public int LinearSearch(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                    return i;
            }
            return -1;
        }

        public int BinarySearch(int[] arr, int target)
        {
            int left = 0, right = arr.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (arr[mid] == target) return mid;
                if (arr[mid] < target) left = mid + 1;
                else right = mid - 1;
            }
            return -1;
        }
    }

}



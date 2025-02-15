using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder_LinearAndBinarySearchAndStreamReader
{
    internal class FirstAndLast
    {
        public void InputMethod()
        {
            int[] nums = { 1, 2, 2, 2, 3, 4, 5 }; // Example sorted array

            Console.Write("Enter target value: ");
            int target = int.Parse(Console.ReadLine());

            var result = FindFirstAndLastOccurrence(nums, target);

            if (result.Item1 != -1)
                Console.WriteLine($"First occurrence: {result.Item1}, Last occurrence: {result.Item2}");
            else
                Console.WriteLine("Target not found in the array.");
        }

        static (int, int) FindFirstAndLastOccurrence(int[] arr, int target)
        {
            int first = FindOccurrence(arr, target, true);
            int last = FindOccurrence(arr, target, false);

            return (first, last);
        }

        static int FindOccurrence(int[] arr, int target, bool findFirst)
        {
            int left = 0, right = arr.Length - 1, result = -1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == target)
                {
                    result = mid; // Possible answer found
                    if (findFirst)
                        right = mid - 1; // Search left for first occurrence
                    else
                        left = mid + 1; // Search right for last occurrence
                }
                else if (arr[mid] < target)
                    left = mid + 1; // Search right half
                else
                    right = mid - 1; // Search left half
            }

            return result;
        }
    }

}


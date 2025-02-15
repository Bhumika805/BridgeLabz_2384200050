using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder_LinearAndBinarySearchAndStreamReader
{
    internal class ChallengeProblem
    {
        public void InputMethod()
        {
            int[] nums = { 3, 4, -1, 1 }; // Example input array
            Console.Write("Enter target value to search: ");
            int target = int.Parse(Console.ReadLine());

            // Find first missing positive integer using Linear Search
            int missingPositive = FindFirstMissingPositive(nums);

            // Sort the array for Binary Search
            Array.Sort(nums);
            int targetIndex = BinarySearch(nums, target);

            Console.WriteLine($"First missing positive integer: {missingPositive}");
            Console.WriteLine(targetIndex != -1
                ? $"Target {target} found at index {targetIndex}"
                : $"Target {target} not found in the array.");
        }

        static int FindFirstMissingPositive(int[] nums)
        {
            int n = nums.Length;

            // Step 1: Mark numbers out of range and place numbers at correct indices
            for (int i = 0; i < n; i++)
            {
                while (nums[i] > 0 && nums[i] <= n && nums[nums[i] - 1] != nums[i])
                {
                    // Swap nums[i] with nums[nums[i] - 1]
                    int temp = nums[i];
                    nums[i] = nums[temp - 1];
                    nums[temp - 1] = temp;
                }
            }

            // Step 2: Find the first missing positive integer
            for (int i = 0; i < n; i++)
            {
                if (nums[i] != i + 1)
                    return i + 1;
            }

            return n + 1; // If all are in place, return n + 1
        }

        static int BinarySearch(int[] arr, int target)
        {
            int left = 0, right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == target)
                    return mid; // Found target, return index

                if (arr[mid] < target)
                    left = mid + 1; // Search right half
                else
                    right = mid - 1; // Search left half
            }

            return -1; // Target not found
        }
    }

}


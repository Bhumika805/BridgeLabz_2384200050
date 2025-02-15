using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder_LinearAndBinarySearchAndStreamReader
{
    internal class PeakElement
    {
        public void InputMethod()
        {
            int[] nums = { 1, 3, 20, 4, 1, 0 }; // Example array

            int peakIndex = FindPeakElement(nums);

            Console.WriteLine($"Peak element is {nums[peakIndex]} at index {peakIndex}");
        }

        static int FindPeakElement(int[] arr)
        {
            int left = 0, right = arr.Length - 1;

            while (left < right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] > arr[mid + 1])
                    right = mid; // Peak must be on the left half (or at mid)
                else
                    left = mid + 1; // Peak must be on the right half
            }

            return left; // Left now points to a peak element
        }
    }

}


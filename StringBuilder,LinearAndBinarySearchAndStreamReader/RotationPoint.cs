using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder_LinearAndBinarySearchAndStreamReader
{
    internal class RotationPoint
    {

        public void InputMethod()
        {
            int[] rotatedArray = { 4, 5, 6, 7, 1, 2, 3 }; // Example rotated sorted array

            int rotationIndex = FindRotationPoint(rotatedArray);

            Console.WriteLine($"Rotation point (smallest element) is at index: {rotationIndex}");
            Console.WriteLine($"Smallest element: {rotatedArray[rotationIndex]}");
        }

        static int FindRotationPoint(int[] arr)
        {
            int left = 0, right = arr.Length - 1;

            while (left < right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] > arr[right])
                    left = mid + 1; // Smallest element must be in the right half
                else
                    right = mid; // Smallest element might be at mid or in the left half
            }

            return left; // Left now points to the index of the smallest element
        }
    }

}


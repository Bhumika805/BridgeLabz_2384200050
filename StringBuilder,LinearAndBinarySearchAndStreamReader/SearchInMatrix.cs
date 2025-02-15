using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder_LinearAndBinarySearchAndStreamReader
{
    internal class SearchInMatrix
    {

        public void InputMethod()
        {
            int[,] matrix =
            {
            { 1, 3, 5, 7 },
            { 10, 11, 16, 20 },
            { 23, 30, 34, 60 }
        };

            Console.Write("Enter target value to search: ");
            int target = int.Parse(Console.ReadLine());

            var result = SearchMatrix(matrix, target);

            if (result.Item1 != -1)
                Console.WriteLine($"Target {target} found at ({result.Item1}, {result.Item2})");
            else
                Console.WriteLine($"Target {target} not found in the matrix.");
        }

        static (int, int) SearchMatrix(int[,] matrix, int target)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int left = 0, right = rows * cols - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                int midValue = matrix[mid / cols, mid % cols]; // Convert 1D index to 2D row & column

                if (midValue == target)
                    return (mid / cols, mid % cols); // Found target, return row and column

                if (midValue < target)
                    left = mid + 1; // Search right half
                else
                    right = mid - 1; // Search left half
            }

            return (-1, -1); // Target not found
        }
    }

}


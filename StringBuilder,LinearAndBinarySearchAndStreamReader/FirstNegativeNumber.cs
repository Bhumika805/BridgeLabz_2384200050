using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder_LinearAndBinarySearchAndStreamReader
{
    internal class FirstNegativeNumber
    {
    public void InputMethod()
        {
            int[] numbers = { 5, 3, 8, 0, -4, 7, -1, 10 }; // Sample array

            int firstNegative = FindFirstNegative(numbers);

            if (firstNegative != int.MaxValue)
                Console.WriteLine($"First negative number found: {firstNegative}");
            else
                Console.WriteLine("No negative numbers found in the array.");
        }

        static int FindFirstNegative(int[] arr)
        {
            foreach (int num in arr) // Linear Search
            {
                if (num < 0)
                    return num; // Return the first negative number
            }
            return int.MaxValue; // Return a special value if no negative number is found
        }
    }

}


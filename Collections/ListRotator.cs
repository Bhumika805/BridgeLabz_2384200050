using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class ListRotator
    {
        public static List<int> RotateList(List<int> items, int positions)
        {
            int n = items.Count;
            positions = positions % n; // Handle cases where positions > n

            if (positions == 0) return new List<int>(items);

            List<int> rotatedList = new List<int>();

            // Add elements from the rotation point to the end
            rotatedList.AddRange(items.GetRange(positions, n - positions));

            // Add elements from the start to the rotation point
            rotatedList.AddRange(items.GetRange(0, positions));

            return rotatedList;
        }

        public void DisplayRotator()
        {
            List<int> inputList = new List<int> { 10, 20, 30, 40, 50 };
            int rotateBy = 2;

            List<int> rotatedList = RotateList(inputList, rotateBy);

            Console.WriteLine("Rotated List: " + string.Join(", ", rotatedList));
        }
    }

}

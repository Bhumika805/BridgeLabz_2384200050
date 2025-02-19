using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class RemoveDuplicates
    {
        public static List<int> RemoveDuplicatesPreserveOrder(List<int> items)
        {
            HashSet<int> seen = new HashSet<int>(); // HashSet to track unique elements
            List<int> result = new List<int>(); // List to store the final output

            foreach (int item in items)
            {
                if (!seen.Contains(item)) // If item is not seen before, add it
                {
                    seen.Add(item); // Mark item as seen
                    result.Add(item); // Add to result list
                }
            }

            return result; // Return the list without duplicates
        }

        public void DisplayDuplicates()
        {
            List<int> inputList = new List<int> { 3, 1, 2, 2, 3, 4 };
            List<int> uniqueList = RemoveDuplicatesPreserveOrder(inputList);

            Console.WriteLine("List after removing duplicates: " + string.Join(", ", uniqueList));
        }
    }

}

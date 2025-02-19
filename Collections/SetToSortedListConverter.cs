using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class SetToSortedListConverter
    {
        public static List<int> ConvertToSortedList(HashSet<int> set)
        {
            List<int> sortedList = new List<int>(set);
            sortedList.Sort(); // Sorts the list in ascending order
            return sortedList;
        }

        public void DisplaySetToSortedList()
        {
            HashSet<int> set = new HashSet<int> { 5, 3, 9, 1 };
            Console.WriteLine("Sorted List: " + string.Join(", ", ConvertToSortedList(set)));
        }
    }

}

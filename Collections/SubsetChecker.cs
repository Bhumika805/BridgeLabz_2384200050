using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
     class SubsetChecker
    {
        public static bool IsSubset(HashSet<int> subset, HashSet<int> mainSet)
        {
            return mainSet.IsSupersetOf(subset); // Checks if mainSet contains all elements of subset
        }

        public void DisplaySubset()
        {
            HashSet<int> subset = new HashSet<int> { 2, 3 };
            HashSet<int> mainSet = new HashSet<int> { 1, 2, 3, 4 };

            Console.WriteLine("Is subset: " + IsSubset(subset, mainSet)); // Output: true
        }
    }

}

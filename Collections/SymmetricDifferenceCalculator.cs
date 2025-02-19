using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class SymmetricDifferenceCalculator
    {
        public static HashSet<int> SymmetricDifference(HashSet<int> set1, HashSet<int> set2)
        {
            HashSet<int> symDiff = new HashSet<int>(set1);
            symDiff.SymmetricExceptWith(set2); // Keeps elements in either set but not both
            return symDiff;
        }

        public void DisplaySymmetric()
        {
            HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
            HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };

            Console.WriteLine("Symmetric Difference: " + string.Join(", ", SymmetricDifference(set1, set2)));
        }
    }

}

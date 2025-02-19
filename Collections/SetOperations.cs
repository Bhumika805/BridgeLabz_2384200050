using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class SetOperations
    {
        public static HashSet<int> Union(HashSet<int> set1, HashSet<int> set2)
        {
            HashSet<int> unionSet = new HashSet<int>(set1);
            unionSet.UnionWith(set2); // Adds all elements from set2
            return unionSet;
        }

        public static HashSet<int> Intersection(HashSet<int> set1, HashSet<int> set2)
        {
            HashSet<int> intersectionSet = new HashSet<int>(set1);
            intersectionSet.IntersectWith(set2); // Keeps only elements found in both sets
            return intersectionSet;
        }

        public void DisplaySetOperations()
        {
            HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
            HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };

            Console.WriteLine("Union: " + string.Join(", ", Union(set1, set2)));
            Console.WriteLine("Intersection: " + string.Join(", ", Intersection(set1, set2)));
        }
    }

}

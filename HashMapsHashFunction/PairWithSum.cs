using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashMapsHashFunction
{
        public class PairWithSum
        {
            public bool HasPairWithSum(int[] arr, int target)
            {
                Dictionary<int, bool> map = new Dictionary<int, bool>();

                for (int i = 0; i < arr.Length; i++)
                {
                    int complement = target - arr[i];

                    // Check if complement exists in the HashMap
                    if (map.ContainsKey(complement))
                    {
                        Console.WriteLine($"Pair found: ({complement}, {arr[i]})");
                        return true;
                    }

                    // Store the current number in the HashMap
                    if (!map.ContainsKey(arr[i]))
                    {
                        map[arr[i]] = true;
                    }
                }

                Console.WriteLine("No pair found.");
                return false;
            }
        }
}



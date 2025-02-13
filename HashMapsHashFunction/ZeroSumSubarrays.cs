using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashMapsHashFunction
{
        public class ZeroSumSubarrays
        {
            public void FindZeroSumSubarrays(int[] arr)
            {
                Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
                int prefixSum = 0;

                // Add base case for prefix sum = 0
                map[0] = new List<int> { -1 };

                Console.WriteLine("Zero-sum subarrays:");

                for (int i = 0; i < arr.Length; i++)
                {
                    prefixSum += arr[i];

                    // If prefixSum exists in the map, print all subarrays
                    if (map.ContainsKey(prefixSum))
                    {
                        foreach (int startIndex in map[prefixSum])
                        {
                            Console.WriteLine($"({startIndex + 1}, {i})");
                        }
                    }

                    // Add current index to the map
                    if (!map.ContainsKey(prefixSum))
                    {
                        map[prefixSum] = new List<int>();
                    }
                    map[prefixSum].Add(i);
                }
            }
        }
}


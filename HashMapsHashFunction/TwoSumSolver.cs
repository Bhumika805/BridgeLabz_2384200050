using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashMapsHashFunction
{
        public class TwoSumSolver
        {
            public int[] TwoSum(int[] nums, int target)
            {
                Dictionary<int, int> numMap = new Dictionary<int, int>();

                for (int i = 0; i < nums.Length; i++)
                {
                    int complement = target - nums[i];

                    // Check if complement exists in HashMap
                    if (numMap.ContainsKey(complement))
                    {
                        return new int[] { numMap[complement], i }; // Return the indices
                    }

                    // Store current number and its index
                    numMap[nums[i]] = i;
                }

                return new int[] { -1, -1 }; // No valid pair found
            }
    }

}



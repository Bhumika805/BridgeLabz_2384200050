using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashMapsHashFunction
{
        public class LongestConsecutiveSequence
        {
            public int FindLongestConsecutive(int[] arr)
            {
                if (arr.Length == 0) return 0;

                Dictionary<int, bool> numSet = new Dictionary<int, bool>();

                // Step 1: Insert all elements into HashSet
                foreach (int num in arr)
                {
                    if (!numSet.ContainsKey(num))
                        numSet[num] = true;
                }

                int maxLength = 0;

                // Step 2: Find the longest sequence
                foreach (int num in arr)
                {
                    // Only check if `num` is the start of a sequence
                    if (!numSet.ContainsKey(num - 1))
                    {
                        int currentNum = num;
                        int currentLength = 1;

                        // Count the length of the consecutive sequence
                        while (numSet.ContainsKey(currentNum + 1))
                        {
                            currentNum++;
                            currentLength++;
                        }

                        // Update max length
                        maxLength = Math.Max(maxLength, currentLength);
                    }
                }

                return maxLength;
            }
        }
 }



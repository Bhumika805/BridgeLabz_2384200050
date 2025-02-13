using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashMapsHashFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ZeroSumSubarrays solver = new ZeroSumSubarrays();
            int[] arr = { 4, 2, -3, 1, 6, -6, 3, -3 };
            solver.FindZeroSumSubarrays(arr);


            PairWithSum obj2 = new PairWithSum();
            int[] arr1 = { 4, 2, 7, 1, 5, 3 };
            int target = 9;
            obj2.HasPairWithSum(arr, target);

            LongestConsecutiveSequence obj3 = new LongestConsecutiveSequence();
            int[] arr2 = { 100, 4, 200, 1, 3, 2 };
            int result = obj3.FindLongestConsecutive(arr);
            Console.WriteLine("Longest Consecutive Sequence Length: " + result);


            CustomHashMap map = new CustomHashMap();
            map.Put(1, 100);
            map.Put(11, 200);
            map.Put(2, 300);
            map.Put(3, 400);


            Console.WriteLine("HashMap after insertions:");
            map.Display();

            Console.WriteLine("\nGet value for key 1: " + map.Get(1));
            Console.WriteLine("Get value for key 2: " + map.Get(2));

            map.Remove(1);
            Console.WriteLine("\nHashMap after removing key 1:");
            map.Display();

            TwoSumSolver obj4 = new TwoSumSolver();
            int[] nums = { 2, 7, 11, 15 };
            int value = 9;

            int[] results = obj4.TwoSum(nums, value);
            Console.WriteLine($"Indices: [{results[0]}, {results[1]}]");
        }
    }
}

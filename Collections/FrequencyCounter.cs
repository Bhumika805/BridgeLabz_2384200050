using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class FrequencyCounter
    {
        public static Dictionary<string, int> CountFrequency(List<string> items)
        {
            Dictionary<string, int> frequencyMap = new Dictionary<string, int>();

            foreach (string item in items)
            {
                if (frequencyMap.ContainsKey(item))
                    frequencyMap[item]++;
                else
                    frequencyMap[item] = 1;
            }

            return frequencyMap;
        }

        public void DisplayFequency()
        {
            List<string> inputList = new List<string> { "apple", "banana", "apple", "orange" };
            Dictionary<string, int> result = CountFrequency(inputList);

            Console.WriteLine("Frequency of elements:");
            foreach (var pair in result)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
    }

}

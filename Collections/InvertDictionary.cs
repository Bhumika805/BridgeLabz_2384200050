using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class InvertDictionary
    {
        public static Dictionary<V, List<K>> InvertMap<K, V>(Dictionary<K, V> inputDict)
        {
            Dictionary<V, List<K>> invertedDict = new Dictionary<V, List<K>>();

            foreach (var entry in inputDict)
            {
                if (!invertedDict.ContainsKey(entry.Value))
                {
                    invertedDict[entry.Value] = new List<K>();
                }
                invertedDict[entry.Value].Add(entry.Key);
            }

            return invertedDict;
        }

        public void DisplayInvertDictionary()
        {
            Dictionary<string, int> input = new Dictionary<string, int>
        {
            { "A", 1 },
            { "B", 2 },
            { "C", 1 }
        };

            Dictionary<int, List<string>> inverted = InvertMap(input);

            Console.WriteLine("Inverted Dictionary:");
            foreach (var entry in inverted)
            {
                Console.WriteLine($"{entry.Key}: [{string.Join(", ", entry.Value)}]");
            }
        }
    }

}

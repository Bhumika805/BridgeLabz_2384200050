using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json.Linq;

namespace JSONProgram
{
    class Program12
    {
        static void Main()
        {
            string file1Path = "file1.json"; // Path to first JSON file
            string file2Path = "file2.json"; // Path to second JSON file

            // Read JSON files
            string json1 = File.ReadAllText(file1Path);
            string json2 = File.ReadAllText(file2Path);

            // Parse JSON files into JObject
            JObject obj1 = JObject.Parse(json1);
            JObject obj2 = JObject.Parse(json2);

            // Merge obj2 into obj1
            obj1.Merge(obj2, new JsonMergeSettings { MergeArrayHandling = MergeArrayHandling.Union });

            // Convert merged JSON to string
            string mergedJson = obj1.ToString();

            // Print merged JSON
            Console.WriteLine(mergedJson);
        }
    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace JSONProgram
{
    class Program4
    {
        static void Main()
        {
            // Define two JSON strings
            string json1 = "{\"name\": \"John Doe\", \"email\": \"john.doe@example.com\"}";
            string json2 = "{\"age\": 30, \"address\": \"123 Main St\"}";

            // Parse JSON strings into JsonNodes
            JsonNode obj1 = JsonNode.Parse(json1);
            JsonNode obj2 = JsonNode.Parse(json2);

            // Merge JSON objects
            foreach (var kvp in obj2.AsObject())
            {
                obj1[kvp.Key] = kvp.Value;
            }

            // Convert merged JSON object back to string
            string mergedJson = obj1.ToJsonString(new JsonSerializerOptions { WriteIndented = true });

            // Print merged JSON
            Console.WriteLine(mergedJson);
        }
    }
}

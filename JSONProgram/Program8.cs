using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace JSONProgram
{

    class Program8
    {
        static void PrintJson(JsonElement element, string prefix = "")
        {
            foreach (var property in element.EnumerateObject())
            {
                string key = prefix + property.Name;

                if (property.Value.ValueKind == JsonValueKind.Object)
                {
                    // Recursively print nested objects
                    PrintJson(property.Value, key + ".");
                }
                else
                {
                    // Print key-value pair
                    Console.WriteLine($"{key}: {property.Value}");
                }
            }
        }

        static void Main()
        {
            string filePath = "data.json"; // Path to JSON file

            // Read JSON file
            string jsonString = File.ReadAllText(filePath);

            // Parse JSON
            using JsonDocument doc = JsonDocument.Parse(jsonString);
            JsonElement root = doc.RootElement;

            // Print all keys and values
            PrintJson(root);
        }
    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace JSONProgram
{
    class Program3
    {
        static void Main()
        {
            string filePath = "data.json"; // Path to JSON file

            // Read JSON file content
            string jsonString = File.ReadAllText(filePath);

            // Parse JSON and extract specific fields
            using JsonDocument doc = JsonDocument.Parse(jsonString);
            JsonElement root = doc.RootElement;

            string name = root.GetProperty("name").GetString();
            string email = root.GetProperty("email").GetString();

            // Display extracted values
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Email: {email}");
        }
    }

}

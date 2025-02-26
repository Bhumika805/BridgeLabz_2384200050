using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace JSONProgram
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
    }

    class Program7
    {
        static void Main()
        {
            string filePath = "data.json"; // Path to JSON file

            // Read JSON file
            string jsonString = File.ReadAllText(filePath);

            // Deserialize JSON array to List<Person>
            List<Person> people = JsonSerializer.Deserialize<List<Person>>(jsonString);

            // Filter records where age > 25
            var filteredPeople = people.Where(p => p.Age > 25).ToList();

            // Convert filtered list back to JSON
            string resultJson = JsonSerializer.Serialize(filteredPeople, new JsonSerializerOptions { WriteIndented = true });

            // Print result
            Console.WriteLine(resultJson);
        }
    }


}

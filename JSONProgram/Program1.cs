using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace JSONProgram
{
    class Program
    {
        static void Main()
        {
            // Create a student object
            var student = new
            {
                Name = "John Doe",
                Age = 20,
                Subjects = new string[] { "Math", "Science", "History" }
            };

            // Serialize object to JSON
            string jsonString = JsonSerializer.Serialize(student, new JsonSerializerOptions { WriteIndented = true });

            // Output JSON string
            Console.WriteLine(jsonString);
        }
    }
}

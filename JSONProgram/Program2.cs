using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace JSONProgram
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }
    class Program2
    {
        static void Main()
        {
            // Create a Car object
            Car myCar = new Car
            {
                Make = "Toyota",
                Model = "Camry",
                Year = 2022
            };
            // Convert Car object to JSON
            string jsonString = JsonSerializer.Serialize(myCar, new JsonSerializerOptions { WriteIndented = true });
            // Print JSON output
            Console.WriteLine(jsonString);
        }
    }

}

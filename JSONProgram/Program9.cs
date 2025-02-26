using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace JSONProgram
{
    class CarProduct
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }
    class Program9
    {
        static void Main()
        {
            // Create a list of Car objects
            List<CarProduct> cars = new List<CarProduct>
        {
            new CarProduct { Make = "Toyota", Model = "Camry", Year = 2022 },
            new CarProduct { Make = "Honda", Model = "Civic", Year = 2021 },
            new CarProduct { Make = "Ford", Model = "Mustang", Year = 2023 }
        };

            // Convert list to JSON
            string jsonString = JsonSerializer.Serialize(cars, new JsonSerializerOptions { WriteIndented = true });

            // Print JSON output
            Console.WriteLine(jsonString);
        }
    }
}

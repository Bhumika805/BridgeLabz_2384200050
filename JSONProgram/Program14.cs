using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;
using CsvHelper;
using Newtonsoft.Json;

namespace JSONProgram
{
    class Persons
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
    }

    class Program14
    {
        static void Main()
        {
            string filePath = "data.csv"; // Path to CSV file

            // Read CSV and convert to list of objects
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Person>(); // Deserialize CSV into Person objects

                // Convert to JSON
                string json = JsonConvert.SerializeObject(records, Formatting.Indented);

                // Print JSON
                Console.WriteLine(json);
            }
        }
    }


}

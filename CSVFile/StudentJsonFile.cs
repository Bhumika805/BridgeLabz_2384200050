using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Xml;

namespace CSVFile
{ 
    class StudentJson
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Grade { get; set; }
    }

    class StudentJsonFile
    {
        static void Main()
        {
            string jsonFilePath = "students.json";
            string csvFilePath = "students.csv";
            string outputJsonFilePath = "students_output.json";

            // Convert JSON to CSV
            ConvertJsonToCsv(jsonFilePath, csvFilePath);

            // Convert CSV back to JSON
            ConvertCsvToJson(csvFilePath, outputJsonFilePath);
        }

        static void ConvertJsonToCsv(string jsonFilePath, string csvFilePath)
        {
            if (!File.Exists(jsonFilePath))
            {
                Console.WriteLine("JSON file not found.");
                return;
            }

            // Read JSON file
            var jsonData = File.ReadAllText(jsonFilePath);
            var students = JsonConvert.DeserializeObject<List<StudentJSON>>(jsonData);

            // Write to CSV
            using (var writer = new StreamWriter(csvFilePath))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(students);
            }

            Console.WriteLine($"Converted JSON to CSV: {csvFilePath}");
        }

        static void ConvertCsvToJson(string csvFilePath, string outputJsonFilePath)
        {
            if (!File.Exists(csvFilePath))
            {
                Console.WriteLine("CSV file not found.");
                return;
            }

            // Read CSV and convert back to JSON
            using (var reader = new StreamReader(csvFilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var students = csv.GetRecords<StudentJSON>();
                string jsonOutput = JsonConvert.SerializeObject(students, Formatting.Indented);
                File.WriteAllText(outputJsonFilePath, jsonOutput);
            }

            Console.WriteLine($"Converted CSV to JSON: {outputJsonFilePath}");
        }
    }

}
}

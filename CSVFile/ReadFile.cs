using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;

namespace CSVFile
{
    public class StudentRecord
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Marks { get; set; }
    }

    class ReadFile
    {
        public void OnlyReadFile()
        {
            string filePath = @"E:\github\CSVFolderText\Student.csv";

            // Check if file exists
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Error: File not found!");
                return;
            }

            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<StudentRecord>().ToList();

                if (records.Count == 0)
                {
                    Console.WriteLine("Error: No data found in the CSV file!");
                    return;
                }

                foreach (var record in records)
                {
                    Console.WriteLine($"ID: {record.ID}, Name: {record.Name}, Age: {record.Age}, Marks: {record.Marks}");
                }
            }
        }

    }
}

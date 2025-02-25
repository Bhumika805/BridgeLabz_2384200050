using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVFile
{
    class Student_Data
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class DuplicateFile
    {
        static void Main()
        {
            string filePath = @"E:\github\CSVFolderText\DuplicateFile.csv"; 

            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found.");
                return;
            }

            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var students = csv.GetRecords<Student_Data>().ToList();

                // Group by ID and find duplicates
                var duplicateRecords = students
                    .GroupBy(s => s.ID)
                    .Where(g => g.Count() > 1)
                    .SelectMany(g => g)
                    .ToList();

                if (duplicateRecords.Any())
                {
                    Console.WriteLine("Duplicate Records Found:");
                    foreach (var student in duplicateRecords)
                    {
                        Console.WriteLine($"ID: {student.ID}, Name: {student.Name}, Age: {student.Age}");
                    }
                }
                else
                {
                    Console.WriteLine("No duplicate records found.");
                }
            }
        }
    }

}


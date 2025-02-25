using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.Globalization;
using System.IO;

namespace CSVFile
{
    class QualifyingStudents
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Marks { get; set; }

        public void FilterQualifiedStudents()
        {
            string filePath = "E:\\github\\CSVFolderText\\QualifiedStudents.csv";

            // Check if file exists
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Error: CSV file not found!");
                return;
            }

            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                // Read all student records from the CSV
                var records = csv.GetRecords<QualifyingStudents>().ToList();

               // Read CSV into objects

                Console.WriteLine("Students who scored more than 80 marks:");
                foreach (var student in records)
                {
                    if (student.Marks > 80)
                    {
                        Console.WriteLine($"Name : {student.Name} Marks : {student.Marks} ID : {student.ID} Age : {student.Age}");
                    }
                }
            }
        }
    }

}



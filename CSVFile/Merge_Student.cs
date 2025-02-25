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
    class Student1
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Student2
    {
        public int ID { get; set; }
        public int Marks { get; set; }
        public string Grade { get; set; }
    }

    class MergedStudent
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Marks { get; set; }
        public string Grade { get; set; }
    }

    class Merge_Student
        {
        static void Main()
        {
            string file1 = @"E:\github\CSVFolderText\students1.csv"; 
            string file2 = @"E:\github\CSVFolderText\students2.csv"; 
            string outputFile = "merged_students.csv";

            if (!File.Exists(file1) || !File.Exists(file2))
            {
                Console.WriteLine("One or both files are missing.");
                return;
            }

            List<Student1> students1;
            List<Student2> students2;

            // Read students1.csv
            using (var reader = new StreamReader(file1))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                students1 = csv.GetRecords<Student1>().ToList();
            }

            // Read students2.csv
            using (var reader = new StreamReader(file2))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                students2 = csv.GetRecords<Student2>().ToList();
            }

            // Merge records based on ID
            var mergedStudents = (from s1 in students1
                                  join s2 in students2 on s1.ID equals s2.ID
                                  select new MergedStudent
                                  {
                                      ID = s1.ID,
                                      Name = s1.Name,
                                      Age = s1.Age,
                                      Marks = s2.Marks,
                                      Grade = s2.Grade
                                  }).ToList();

            // Write merged data to a new CSV file
            using (var writer = new StreamWriter(outputFile))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(mergedStudents);
            }

            Console.WriteLine($"Merged file '{outputFile}' created successfully.");
        }
    }

}


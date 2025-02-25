using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace CSVFile
{
    class Class1
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Grade { get; set; }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Age: {Age}, Grade: {Grade}";
        }
    }

    class StudentClass
    {
        static void Main()
        {
            string filePath = @"E:\github\CSVFolderText\Student.csv"; 

            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found.");
                return;
            }

            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var students = csv.GetRecords<Class1>().ToList();

                Console.WriteLine("Students List:");
                foreach (var student in students)
                {
                    Console.WriteLine(student);
                }
            }
        }
    }

}

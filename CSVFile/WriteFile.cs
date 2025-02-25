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
    public class EmployeeRecord
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public int Salary { get; set; }
    }

    class WriteFile
    {
        public void OnlyWriteFile()
        {
            string filePath = @"E:\github\CSVFolderText\Employee.csv";

            // Check if file exists
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Error: File not found!");
                return;
            }
            var employees = new List<EmployeeRecord>
            {
                new EmployeeRecord { ID = 1, Name = "Bhumika", Department = "Developer", Salary = 400000 },
                new EmployeeRecord { ID = 2, Name = "Riddhi", Department = "Developer", Salary = 500000 },
                new EmployeeRecord { ID = 3, Name = "Joe", Department = "Data Analyst", Salary = 200000 },
                new EmployeeRecord { ID = 3, Name = "Muskan", Department = "Data Analyst", Salary = 250000 },
                new EmployeeRecord { ID = 3, Name = "Arya", Department = "Data Analyst", Salary = 500000 }
            };

            using (var writer = new StreamWriter(filePath))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(employees);
            }
            Console.WriteLine("CSV File writeen succesfully");
        }

    }
}

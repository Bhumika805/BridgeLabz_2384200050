using System;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;
using System.Collections.Generic;

namespace CSVFile
{
    class EmployeeProgram
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
    }

    class ITDevelopment
    {
        static void Main()
        {
            string inputFilePath = @"E:\github\CSVFolderText\Employee.csv";
            string outputFilePath = @"E:\github\CSVFolderText\updated_employees.csv";

            if (!File.Exists(inputFilePath))
            {
                Console.WriteLine("File not found.");
                return;
            }

            // Read the CSV file
            using (var reader = new StreamReader(inputFilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var employees = csv.GetRecords<EmployeeProgram>().ToList(); // Read CSV into a list

                // Update salaries for IT department
                foreach (var emp in employees)
                {
                    if (emp.Department.Equals("IT", StringComparison.OrdinalIgnoreCase))
                    {
                        emp.Salary *= 1.10m; // Increase salary by 10%
                    }
                }

                // Write the updated data to a new CSV file
                using (var writer = new StreamWriter(outputFilePath))
                using (var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csvWriter.WriteRecords(employees);
                }

                Console.WriteLine($"Updated salaries saved to {outputFilePath}");
            }
        }
    }
}

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
    class Records_of_EmployeeByColumn
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
    }

    class RecordsbyColumn
    {
        static void Main()
        {
            string filePath = @"E:\github\CSVFolderText\HighestPaidSalary.csv";

            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found.");
                return;
            }

            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var employees = csv.GetRecords<Employee>()
                                   .OrderByDescending(e => e.Salary)  // Sort by salary (descending)
                                   .Take(5)  // Get top 5 highest-paid employees
                                   .ToList();

                Console.WriteLine("Top 5 Highest-Paid Employees:");
                foreach (var emp in employees)
                {
                    Console.WriteLine($"{emp.Name} - {emp.Department} - ${emp.Salary}");
                }
            }
        }
    }

}


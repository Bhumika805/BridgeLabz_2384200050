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
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public int Salary { get; set; }
    }

    class SearchEmployee
    {
        public void OnlyWriteFile()
        {
            string filePath = "E:\\github\\CSVFolderText\\Employee.csv";

            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found.");
                return;
            }

            Console.Write("Enter employee name to search: ");
            string searchName = Console.ReadLine();

            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var employees = csv.GetRecords<Employee>().ToList(); // Read CSV into a list

                var employee = employees.FirstOrDefault(e => e.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase));

                if (employee != null)
                {
                    Console.WriteLine($"\nEmployee Found:");
                    Console.WriteLine($"Name: {employee.Name}");
                    Console.WriteLine($"Department: {employee.Department}");
                    Console.WriteLine($"Salary: ${employee.Salary}");
                }
                else
                {
                    Console.WriteLine("Employee not found.");
                }
            }

        }
    }
}

using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSVFile
{
    public class Valid  // Fix 1: Renamed from ValidFormat to Employee
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }

    class ValidEmailFormat
    {
        static void Main()
        {
            string filePath = @"E:\github\CSVFolderText\ValidFormat.csv";

            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found.");
                return;
            }

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$"; // Simple email regex
            string phonePattern = @"^\d{10}$"; // 10-digit phone number

            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var employees = csv.GetRecords<Valid>().ToList();  // Fix 2: Use Employee class

                Console.WriteLine("Validating CSV Data...\n");

                bool hasErrors = false;
                foreach (var emp in employees)
                {
                    bool isValidEmail = Regex.IsMatch(emp.Email, emailPattern);
                    bool isValidPhone = Regex.IsMatch(emp.PhoneNumber, phonePattern);

                    if (!isValidEmail || !isValidPhone)
                    {
                        hasErrors = true;
                        Console.WriteLine($"Invalid Record: {emp.Name}");
                        if (!isValidEmail)
                            Console.WriteLine($"  - Invalid Email: {emp.Email}");
                        if (!isValidPhone)
                            Console.WriteLine($"  - Invalid Phone Number: {emp.PhoneNumber}");
                    }
                }

                if (!hasErrors)
                {
                    Console.WriteLine("All records are valid.");
                }
            }
        }
    }
}


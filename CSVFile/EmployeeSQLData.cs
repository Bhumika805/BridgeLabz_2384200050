using CsvHelper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVFile
{
    class EmployeeSQL
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
    }

    class EmployeeSQLData
        {
        static void Main()
        {
            string connectionString = "Server=your_server;Database=your_db;User Id=your_user;Password=your_password;";
            string query = "SELECT EmployeeID, Name, Department, Salary FROM Employees";
            string csvFilePath = @"E:\github\CSVFolderText\Employeesql.csv";

            List<EmployeeSQL> employees = new List<EmployeeSQL>();

            // Fetch records from the database
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        employees.Add(new EmployeeSQL
                        {
                            EmployeeID = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Department = reader.GetString(2),
                            Salary = reader.GetDecimal(3)
                        });
                    }
                }
            }

            // Write records to CSV file
            using (var writer = new StreamWriter(csvFilePath))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(employees);
            }

            Console.WriteLine($"CSV report generated: {csvFilePath}");
        }
    }

}


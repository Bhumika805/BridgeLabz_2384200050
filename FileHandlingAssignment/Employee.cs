using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace FileHandlingAssignment
{
    [Serializable]
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }

        public Employee(int id, string name, string department, double salary)
        {
            Id = id;
            Name = name;
            Department = department;
            Salary = salary;
        }
    }

    public class EmployeeManager
    {
        private string filePath;

        public EmployeeManager(string path)
        {
            filePath = path;
        }

        // Method to serialize and save employees to a file
        public void SaveEmployees(List<Employee> employees)
        {
            try
            {
                string jsonData = JsonSerializer.Serialize(employees, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, jsonData);
                Console.WriteLine("Employees saved successfully!");
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error saving employees: " + ex.Message);
            }
        }

        // Method to deserialize and load employees from a file
        public List<Employee> LoadEmployees()
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    Console.WriteLine("No employee data found.");
                    return new List<Employee>();
                }

                string jsonData = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<List<Employee>>(jsonData) ?? new List<Employee>();
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error loading employees: " + ex.Message);
                return new List<Employee>();
            }
        }
    }

    class Program1
    {
        static void Main()
        {
            string filePath = "employees.json";
            EmployeeManager manager = new EmployeeManager(filePath);

            // Creating sample employees
            List<Employee> employees = new List<Employee>
            {
                new Employee(1, "Alice", "HR", 50000),
                new Employee(2, "Bob", "IT", 70000),
                new Employee(3, "Charlie", "Finance", 65000)
            };

            // Serialize and save employees
            manager.SaveEmployees(employees);

            // Deserialize and load employees
            List<Employee> loadedEmployees = manager.LoadEmployees();
            Console.WriteLine("\nLoaded Employees:");
            foreach (var emp in loadedEmployees)
            {
                Console.WriteLine($"ID: {emp.Id}, Name: {emp.Name}, Department: {emp.Department}, Salary: {emp.Salary}");
            }
        }
    }
}



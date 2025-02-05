using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Level1
{
        internal class Employee
        {
            private static string CompanyName = "Capgemini"; // Shared by all employees
            private static int totalEmployees = 0; // Count of total employees

            public readonly int EmployeeId; // Unique ID, cannot be changed after assignment
            public string Name;
            public string Designation;
            public string City;
            public int WorkingFromYear;

            private static Random random = new Random(); // For generating random Employee ID

        public static void DisplayCompanyName()
        {
            Console.WriteLine($"Company is {CompanyName}");
        }

        // Constructor to initialize employee details
        public Employee(string name, string designation, string city, int workingFromYear)
            {
                this.EmployeeId = random.Next(1000, 9999); // Random unique Employee ID
                this.Name = name;
                this.Designation = designation;
                this.City = city;
                this.WorkingFromYear = workingFromYear;
                totalEmployees++; // Increment total employee count
            }

            // Static method to display total employees
            public static void DisplayTotalEmployees()
            {
                Console.WriteLine($"\nTotal Employees in {CompanyName}: {totalEmployees}");
            }

            // Method to display employee details
            public void DisplayEmployeeInfo()
            {
                if (this is Employee)
                {
                    Console.WriteLine("\nEmployee Details:");
                    Console.WriteLine($"Employee ID: {EmployeeId}");
                    Console.WriteLine($"Name: {Name}");
                    Console.WriteLine($"Designation: {Designation}");
                    Console.WriteLine($"City: {City}");
                    Console.WriteLine($"Working Since: {WorkingFromYear}");
                }
                else
                {
                    Console.WriteLine("Invalid Employee object.");
                }
            }
        }

        class EmployeeSystem
        {
            private List<Employee> employees = new List<Employee>(); // Store employees

            // Method to add a new employee
            public void AddEmployee()
            {
                Console.Write("Enter Employee Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Employee Designation: ");
                string designation = Console.ReadLine();

                Console.Write("Enter Employee City: ");
                string city = Console.ReadLine();

                Console.Write("Enter Working From Year: ");
                int workingFromYear;
                while (!int.TryParse(Console.ReadLine(), out workingFromYear) || workingFromYear < 1900 || workingFromYear > DateTime.Now.Year)
                {
                    Console.Write("Invalid input! Enter a valid Working From Year: ");
                }

                Employee newEmployee = new Employee(name, designation, city, workingFromYear);
                employees.Add(newEmployee);

                Console.WriteLine("\nEmployee added successfully!");
                newEmployee.DisplayEmployeeInfo();
            }

            // Method to find an employee by ID
            public Employee FindEmployee(int id)
            {
                return employees.Find(emp => emp.EmployeeId == id);
            }

            // Employee management system with switch case
            public void EmployeeManagement()
            {

            Employee.DisplayCompanyName();

            while (true)
                {
                    Console.WriteLine("\nEmployee Management Menu:");
                    Console.WriteLine("1. Add Employee");
                    Console.WriteLine("2. View Employee Details");
                    Console.WriteLine("3. Display Total Employees");
                    Console.WriteLine("4. Exit");
                    Console.Write("Enter your choice (1-4): ");

                    int choice;
                    while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
                    {
                        Console.Write("Invalid choice! Enter a number between 1-4: ");
                    }

                    switch (choice)
                    {
                        case 1:
                            AddEmployee();
                            break;

                        case 2:
                            Console.Write("Enter Employee ID to Search: ");
                            int searchId;
                            while (!int.TryParse(Console.ReadLine(), out searchId))
                            {
                                Console.Write("Invalid input! Enter a valid Employee ID: ");
                            }

                            Employee emp = FindEmployee(searchId);
                            if (emp != null)
                            {
                                emp.DisplayEmployeeInfo();
                            }
                            else
                            {
                                Console.WriteLine("Employee not found!");
                            }
                            break;

                        case 3:
                            Employee.DisplayTotalEmployees();
                            break;

                        case 4:
                            Console.WriteLine("\nThank you for using Employee Management System!");
                            return;
                    }
                }
            }
        }

}

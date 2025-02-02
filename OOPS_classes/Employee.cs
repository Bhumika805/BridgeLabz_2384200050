using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_classes
{
    class Employee
    {
        // Public access modifier: Accessible from anywhere
        public int employeeID;

        // Protected access modifier: Accessible within the class and derived classes
        protected string department;

        // Private access modifier: Accessible only within the class
        private double salary;

        // Constructor to initialize employee details
        public Employee(int employeeID, string department, double salary)
        {
            this.employeeID = employeeID;
            this.department = department;
            this.salary = salary > 0 ? salary : 30000; // Default minimum salary
        }

        // Public method to modify the salary
        public void SetSalary(double newSalary)
        {
            if (newSalary > 0)
            {
                salary = newSalary;
                Console.WriteLine($"Salary updated successfully.");
            }
            else
            {
                Console.WriteLine("Invalid salary amount. Salary must be positive.");
            }
        }

        // Public method to get the salary
        public double GetSalary()
        {
            return salary;
        }

        // Method to display employee details
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"Employee ID: {employeeID}");
            Console.WriteLine($"Department: {department}");
            Console.WriteLine($"Salary: {salary:C}"); // C format to display currency
        }
    }

    // Derived class: Manager
    class Manager : Employee
    {
        // Constructor to initialize manager details
        public Manager(int employeeID, string department, double salary)
            : base(employeeID, department, salary)
        {
        }

        // Method to display manager details (accessing base class members)
        public void DisplayManagerDetails()
        {
            Console.WriteLine("\nManager Details:");
            Console.WriteLine($"Employee ID: {employeeID}");  // Accessing public member employeeID
            Console.WriteLine($"Department: {department}");  // Accessing protected member department
        }
    }

}

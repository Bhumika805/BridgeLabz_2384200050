using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Assignment
{
    interface IDepartment
    {
        void AssignDepartment(string department);
        string GetDepartmentDetails();
    }
    // Abstract class defining common employee properties
    abstract class Employee
    {
        private int employeeId;
        private string name;
        private double baseSalary;

        public Employee(int employeeId, string name, double baseSalary)
        {
            this.employeeId = employeeId;
            this.name = name;
            this.baseSalary = baseSalary;
        }

        public int EmployeeId { get { return employeeId; } }
        public string Name { get { return name; } }
        public double BaseSalary { get {return baseSalary; } }

        //abstract method to be implemented by subclasses
        public abstract double CalculateSalary();

        //concrete method to display details
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"ID: {EmployeeId}, Name: {Name}, Salary: {CalculateSalary():C}");
        }
    }

    //full-time employee subclass
    class FullTimeEmployee : Employee, IDepartment
    {
        private double fixedSalary;
        private string department;

        public FullTimeEmployee(int employeeId, string name, double baseSalary, double fixedSalary) : base(employeeId, name, baseSalary)
        {
            this.fixedSalary = fixedSalary;
        }

        public override double CalculateSalary()
        {
            return BaseSalary + fixedSalary;
        }

        public void AssignDepartment(string department)
        {
            this.department = department;
        }

        public string GetDepartmentDetails()
        {
            return $"Department : {department}";
        }
    }

    class PartTimeEmployee : Employee, IDepartment
    {
        private int hoursWorked;
        private double hourlyRate;
        private string department;

        public PartTimeEmployee(int employeeId, string name, double baseSalary, int hoursWorked, double hourlyRate) : base(employeeId, name, baseSalary)
        {
            this.hoursWorked = hoursWorked;
            this.hourlyRate = hourlyRate;

        }

        public override double CalculateSalary()
        {
            return BaseSalary + (hoursWorked * hourlyRate);
        }

        public void AssignDepartment(string department)
        {
            this.department = department;
        }

        public string GetDepartmentDetails()
        {
            return $"Department: {department}";
        }
    }

}

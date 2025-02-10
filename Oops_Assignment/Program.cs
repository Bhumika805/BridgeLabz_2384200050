using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
            new FullTimeEmployee(101, "Alice", 5000, 2000),
            new PartTimeEmployee(102, "Bob", 3000, 20, 50)
            };

            foreach (var emp in employees)
            {
                emp.DisplayDetails();

                if (emp is IDepartment dept)
                {
                    dept.AssignDepartment(emp is FullTimeEmployee ? "HR" : "Finance");
                    Console.WriteLine(dept.GetDepartmentDetails());
                }

                Console.WriteLine();
            }
        }
    }
}

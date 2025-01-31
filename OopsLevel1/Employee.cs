using System;

namespace OOPSLevel1
{
    public class Employee
    {
        private string name;
        private int id;
        private double salary;

        public void InputDetails()
        {
            Console.Write("Enter Employee Name: ");
            name = Console.ReadLine();
            
            Console.Write("Enter Employee ID: ");
            id = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter Employee Salary: ");
            salary = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayDetails()
        {
            Console.WriteLine("\nEmployee Details:");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Salary: " + salary);
        }
    }
}

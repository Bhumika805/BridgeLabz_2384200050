using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Inheritance_Problems
{
    internal class Employee
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public double Salary { get; set; }

        public Employee(string name, int id, double salary)
        {
            Name = name;
            Id = id;
            Salary = salary;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine("Employee Details are --");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Salary: {Salary}");
        }
    }

    class Manager : Employee
    {
        public int TeamSize { get; set; }

        public Manager(string name, int id, double salary, int teamsize) : base(name, id, salary)
        {
            TeamSize = teamsize;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine("Manager Details:");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Salary: {Salary}");
            Console.WriteLine($"Team Size: {TeamSize}");
            Console.WriteLine("---------------------------");
        }
    }

    class Developer : Employee
    {
        public string ProgrammingLanguage { get; set; }

        public Developer(string name, int id, double salary, string programmingLanguage) : base(name, id, salary)
        {
            ProgrammingLanguage = programmingLanguage;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine("Developer Details:");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Salary: {Salary}");
            Console.WriteLine($"Programming Language: {ProgrammingLanguage}");
            Console.WriteLine("---------------------------");
        }
    }

    class Intern : Employee
    {
        public string InternshipDuration { get; set; }

        public Intern(string name, int id, double salary, string internshipDuration) : base(name, id, salary)
        {
            InternshipDuration = internshipDuration;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine("Intern Details:");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Salary: {Salary}");
            Console.WriteLine($"Internship Duration: {InternshipDuration}");
            Console.WriteLine("---------------------------");
        }
    }
}

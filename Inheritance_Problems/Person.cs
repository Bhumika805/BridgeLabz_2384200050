using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Problems
{
    // Base Class: Person
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void DisplayRole()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
        }
    }

    // Subclass: Teacher (Inherits from Person)
    class Teacher : Person
    {
        public string Subject { get; set; }

        public Teacher(string name, int age, string subject) : base(name, age)
        {
            Subject = subject;
        }

        public override void DisplayRole()
        {
            base.DisplayRole();
            Console.WriteLine($"Role: Teacher");
            Console.WriteLine($"Subject: {Subject}");
        }
    }

    // Subclass: Student (Inherits from Person)
    class Student : Person
    {
        public string Grade { get; set; }

        public Student(string name, int age, string grade) : base(name, age)
        {
            Grade = grade;
        }

        public override void DisplayRole()
        {
            base.DisplayRole();
            Console.WriteLine($"Role: Student");
            Console.WriteLine($"Grade: {Grade}");
        }
    }

    // Subclass: Staff (Inherits from Person)
    class Staff : Person
    {
        public string Department { get; set; }

        public Staff(string name, int age, string department) : base(name, age)
        {
            Department = department;
        }

        public override void DisplayRole()
        {
            base.DisplayRole();
            Console.WriteLine($"Role: Staff");
            Console.WriteLine($"Department: {Department}");
        }
    }
}


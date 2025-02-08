using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Problems
{
    // Base Class: Persons
    class Persons
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public Persons(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"ID: {Id}");
        }
    }

    // Interface: Worker (For Hybrid Inheritance)
    interface IWorker
    {
        void PerformDuties();
    }

    // Subclass: Chef (Inherits from Persons & Implements IWorker)
    class Chef : Persons, IWorker
    {
        public string Specialty { get; set; }

        public Chef(string name, int id, string specialty) : base(name, id)
        {
            Specialty = specialty;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Role: Chef");
            Console.WriteLine($"Specialty: {Specialty}");
        }

        public void PerformDuties()
        {
            Console.WriteLine($"{Name} is preparing delicious meals.");
        }
    }

    // Subclass: Waiter (Inherits from Persons & Implements IWorker)
    class Waiter : Persons, IWorker
    {
        public int TableCount { get; set; }

        public Waiter(string name, int id, int tableCount) : base(name, id)
        {
            TableCount = tableCount;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Role: Waiter");
            Console.WriteLine($"Tables Assigned: {TableCount}");
        }

        public void PerformDuties()
        {
            Console.WriteLine($"{Name} is serving customers at {TableCount} tables.");
        }
    }
}


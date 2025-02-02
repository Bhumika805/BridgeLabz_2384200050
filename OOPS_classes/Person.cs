using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_classes
{
    class Person
    {
        private string name;
        private int age;

        // Parameterized Constructor
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age > 0 ? age : 1; // Ensure valid age
        }

        // Copy Constructor (Clones another Person object)
        public Person(Person other)
        {
            this.name = other.name;
            this.age = other.age;
        }

        // Method to display person details
        public void Display()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }

        // Static method to take user input for creating a Person object
        public static Person GetPersonDetails()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            int age = -1;
            while (age <= 0)
            {
                Console.Write("Enter age: ");
                string input = Console.ReadLine();

                // Check if input is a valid number
                bool isValid = true;
                foreach (char c in input)
                {
                    if (!char.IsDigit(c))
                    {
                        isValid = false;
                        break;
                    }
                }

                if (isValid && input.Length > 0)
                {
                    age = Convert.ToInt32(input);
                    if (age <= 0)
                    {
                        Console.WriteLine("Age must be greater than zero.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid age (numbers only).");
                }
            }

            return new Person(name, age);
        }
    }

}

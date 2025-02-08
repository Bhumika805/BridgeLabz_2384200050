using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Problems
{
    internal class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age) 
        {
            Name = name;
            Age = age;
        }
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age)
        {
            
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} Dog barks, age- {Age}");
        }
    }

    class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age)
        {

        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} Cat meows, age- {Age}");
        }
    }

    class Bird : Animal
    {
        public Bird(string name, int age) : base(name, age)
        {

        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} Bird chirps, age- {Age}");
        }
    }

}

using Inheritance_Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Problems
{
    internal class CallingMethod
    {
        public void CallingAnimals()
        {
            Console.Write("Enter the animal (Dog/Cat/Bird): ");
            string type = Console.ReadLine().Trim().ToLower();

            Console.Write("Enter the name of the animal: ");
            string name = Console.ReadLine();

            int age;
            while (true)
            {
                Console.Write("Enter the age of the animal: ");
                if (int.TryParse(Console.ReadLine(), out age) && age >= 0)
                {
                    break;
                }
                Console.WriteLine("Invalid input. Please enter a valid non-negative age.");
            }

            Animal animal;

            switch (type)
            {
                case "dog":
                    animal = new Dog(name, age);
                    break;

                case "cat":
                    animal = new Cat(name, age);
                    break;

                case "bird":
                    animal = new Bird(name, age);
                    break;

                default:
                    Console.WriteLine("Invalid animal type. Please enter Dog, Cat, or Bird.");
                    return;
            }

            // Call the MakeSound() method to demonstrate polymorphism
            animal.MakeSound();
        }

        public void DisplayEmployees()
        {
            List<Employee> employees = new List<Employee>
            {
                new Manager("Alice Johnson", 101, 85000, 10),
                new Developer("Bob Smith", 102, 75000, "C#"),
                new Intern("Charlie Brown", 103, 20000, "6 months")
            };

            Console.WriteLine("\nEmployee Details:");
            foreach (Employee emp in employees)
            {
                emp.DisplayDetails();
                Console.WriteLine("----------------------------");
            }
        }

        public void DisplayVehicles()
        {
            // Creating an array of Vehicle type
            Vehicle[] vehicles = new Vehicle[]
            {
                new Car(200, "Petrol", 5),
                new Truck(120, "Diesel", 5000),
                new Motorcycle(180, "Petrol", false)
            };

            // Demonstrate polymorphism: Dynamic method dispatch
            foreach (Vehicle v in vehicles)
            {
                v.DisplayInfo();
            }
        }

        public void DisplayBooks()
        {
            // Creating an instance of Author (which also contains Book properties)
            Author author = new Author("The Great Gatsby", 1925, "F. Scott Fitzgerald",
                "An American novelist known for his works depicting the Jazz Age.");

            // Demonstrate single inheritance
            author.DisplayInfo();
        }

        public void DisplayHomeDevices()
        {
            // Creating an instance of Thermostat (which also contains Device properties)
            Thermostat thermostat = new Thermostat("TH123", "Online", 22.5);

            // Demonstrate single inheritance
            thermostat.DisplayStatus();
        }

        public void DisplayOrders()
        {
            // Creating instances of each class
            Order order = new Order(1001, DateTime.Now);
            ShippedOrder shippedOrder = new ShippedOrder(1002, DateTime.Now.AddDays(-2), "TRK12345");
            DeliveredOrder deliveredOrder = new DeliveredOrder(1003, DateTime.Now.AddDays(-5), "TRK67890", DateTime.Now.AddDays(-1));

            Console.WriteLine("----- Order Details -----");
            order.GetOrderStatus();
            Console.WriteLine();

            Console.WriteLine("----- Shipped Order Details -----");
            shippedOrder.GetOrderStatus();
            Console.WriteLine();

            Console.WriteLine("----- Delivered Order Details -----");
            deliveredOrder.GetOrderStatus();
        }

        public void DisplayCourses()
        {
            // Creating instances of each class
            Course basicCourse = new Course("Data Structures", 8);
            OnlineCourse onlineCourse = new OnlineCourse("Web Development", 12, "Udemy", true);
            PaidOnlineCourse paidCourse = new PaidOnlineCourse("Machine Learning", 16, "Coursera", true, 500, 20);

            Console.WriteLine("----- Basic Course Details -----");
            basicCourse.DisplayInfo();
            Console.WriteLine();

            Console.WriteLine("----- Online Course Details -----");
            onlineCourse.DisplayInfo();
            Console.WriteLine();

            Console.WriteLine("----- Paid Online Course Details -----");
            paidCourse.DisplayInfo();
        }

        public void DisplayBankAccounts()
        {
            // Creating instances of different account types
            SavingsAccount savings = new SavingsAccount(101, 5000, 3.5);
            CheckingAccount checking = new CheckingAccount(102, 2000, 1000);
            FixedDepositAccount fixedDeposit = new FixedDepositAccount(103, 10000, 12);

            Console.WriteLine("----- Savings Account Details -----");
            savings.DisplayInfo();
            Console.WriteLine();

            Console.WriteLine("----- Checking Account Details -----");
            checking.DisplayInfo();
            Console.WriteLine();

            Console.WriteLine("----- Fixed Deposit Account Details -----");
            fixedDeposit.DisplayInfo();
        }

        public void DisplaySchoolDetails()
        {
            // Creating objects of subclasses
            Teacher teacher = new Teacher("Alice Johnson", 35, "Mathematics");
            Student student = new Student("Bob Smith", 16, "10th Grade");
            Staff staff = new Staff("Charlie Brown", 40, "Administration");

            Console.WriteLine("----- Teacher Details -----");
            teacher.DisplayRole();
            Console.WriteLine();

            Console.WriteLine("----- Student Details -----");
            student.DisplayRole();
            Console.WriteLine();

            Console.WriteLine("----- Staff Details -----");
            staff.DisplayRole();
        }

        public void DisplayRestaurant()
        {
            // Creating objects of Chef and Waiter
            Chef chef = new Chef("Gordon Ramsay", 101, "Italian Cuisine");
            Waiter waiter = new Waiter("John Doe", 201, 5);

            Console.WriteLine("----- Chef Details -----");
            chef.DisplayInfo();
            chef.PerformDuties();
            Console.WriteLine();

            Console.WriteLine("----- Waiter Details -----");
            waiter.DisplayInfo();
            waiter.PerformDuties();
        }

        public void DisplayVehicleSystem()
        {
            // Creating objects of ElectricVehicle and PetrolVehicle
            ElectricVehicle tesla = new ElectricVehicle("Tesla Model S", 250, 100);
            PetrolVehicle mustang = new PetrolVehicle("Ford Mustang", 220, 60);

            Console.WriteLine("----- Electric Vehicle Details -----");
            tesla.DisplayInfo();
            tesla.Charge();
            Console.WriteLine();

            Console.WriteLine("----- Petrol Vehicle Details -----");
            mustang.DisplayInfo();
            mustang.Refuel();
        }
    }
    
}



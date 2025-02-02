using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_classes
{
    using System;

    // Base class: Student
    class Student
    {
        // Public access modifier: Accessible from anywhere
        public int rollNumber;

        // Protected access modifier: Accessible within the class and derived classes
        protected string name;

        // Private access modifier: Accessible only within the class
        private double CGPA;

        // Constructor to initialize student details
        public Student(int rollNumber, string name, double CGPA)
        {
            this.rollNumber = rollNumber;
            this.name = name;
            this.CGPA = CGPA;
        }

        // Public method to get the CGPA value (Accessor)
        public double GetCGPA()
        {
            return CGPA;
        }

        // Public method to set the CGPA value (Mutator)
        public void SetCGPA(double CGPA)
        {
            if (CGPA >= 0 && CGPA <= 10)
            {
                this.CGPA = CGPA; // Set CGPA if valid
            }
            else
            {
                Console.WriteLine("Invalid CGPA value. CGPA should be between 0 and 10.");
            }
        }

        // Method to display student details
        public void DisplayStudentDetails()
        {
            Console.WriteLine($"Roll Number: {rollNumber}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"CGPA: {CGPA}");
        }
    }

    // Derived class: PostgraduateStudent
    class PostgraduateStudent : Student
    {
        // Constructor to initialize postgraduate student details
        public PostgraduateStudent(int rollNumber, string name, double CGPA)
            : base(rollNumber, name, CGPA)
        {
        }

        // Method to display postgraduate student details
        public void DisplayPostgraduateDetails()
        {
            // Accessing protected member 'name' from the base class
            Console.WriteLine($"\nPostgraduate Student Details:");
            Console.WriteLine($"Roll Number: {rollNumber}");
            Console.WriteLine($"Name: {name}");  // Accessing protected member
            Console.WriteLine($"CGPA: {GetCGPA()}");  // Using the public method to get CGPA
        }
    }
}

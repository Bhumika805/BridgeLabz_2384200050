using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_classes
{
    internal class Circle
    {
        private double radius;

        // Default constructor (calls parameterized constructor with default value)
        public Circle() : this(1.0)
        {
        }

        // Parameterized constructor (sets radius to user-provided value)
        public Circle(double radius)
        {
            this.radius = radius > 0 ? radius : 1.0; // Ensure valid radius
        }

        // Method to calculate area
        public double GetArea()
        {
            return Math.PI * radius * radius;
        }

        // Method to display radius and area
        public void Display()
        {
            Console.WriteLine($"Circle Radius: {radius}");
            Console.WriteLine($"Circle Area: {GetArea()}");
        }

        // Static method to take user input for radius
        public static double GetUserRadius()
        {
            double radius = -1;
            while (radius <= 0)
            {
                Console.Write("Enter radius for the circle: ");
                string input = Console.ReadLine();

                bool isValid = true;
                int dotCount = 0;

                foreach (char c in input)
                {
                    if (!char.IsDigit(c))
                    {
                        if (c == '.' && dotCount == 0)
                        {
                            dotCount++;
                        }
                        else
                        {
                            isValid = false;
                            break;
                        }
                    }
                }

                if (isValid && input.Length > 0)
                {
                    radius = Convert.ToDouble(input);
                    if (radius <= 0)
                    {
                        Console.WriteLine("Radius must be greater than zero.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid radius (numbers only).");
                }
            }

            return radius;
        }
    }
}

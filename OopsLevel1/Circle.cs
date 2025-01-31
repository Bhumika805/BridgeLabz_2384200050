using System;

namespace OOPSLevel1
{
    public class Circle
    {
        private double radius;

        public void InputRadius()
        {
            Console.Write("Enter Radius of the Circle: ");
            radius = Convert.ToDouble(Console.ReadLine());
        }

        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

        public double CalculateCircumference()
        {
            return 2 * Math.PI * radius;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("\nCircle Details:");
            Console.WriteLine("Radius: " + radius);
            Console.WriteLine("Area: " + CalculateArea());
            Console.WriteLine("Circumference: " + CalculateCircumference());
        }
    }
}
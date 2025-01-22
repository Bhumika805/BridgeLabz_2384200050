using System;

namespace Submission_of_Programming_Elements_Practices
{
    // Class to calculate the area of a triangle
    class TriangleCalc
    {
        public void CalculateArea()
        {
            // Prompt the user to enter the base of the triangle in cm
            Console.Write("Enter the base of the triangle in cm: ");
            double baseCm = Convert.ToDouble(Console.ReadLine());

            // Prompt the user to enter the height of the triangle in cm
            Console.Write("Enter the height of the triangle in cm: ");
            double heightCm = Convert.ToDouble(Console.ReadLine());

            // Calculate the area in square centimeters and convert it to square inches
            double areaCm2 = 0.5 * baseCm * heightCm; // Formula: 1/2 * base * height
            double areaIn2 = areaCm2 / 6.4516;       // 1 square inch = 6.4516 square centimeters

            // Display the area in both square centimeters and square inches
            Console.WriteLine($"The area of the triangle is: {areaCm2:F2} square centimeters, {areaIn2:F2} square inches");
        }
    }
}

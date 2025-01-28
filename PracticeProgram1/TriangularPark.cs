using System;

namespace PracticeProblem1
{
    class TriangularPark
    {
        public void Triangular__Park()
        {
            Console.WriteLine("Enter the lengths of the three sides of the triangular park (in meters):");

            Console.Write("Side 1: ");
            double side1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Side 2: ");
            double side2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Side 3: ");
            double side3 = Convert.ToDouble(Console.ReadLine());

            // Compute the perimeter of the triangle
            double perimeter = ComputePerimeter(side1, side2, side3);

            if (perimeter > 0)
            {
                // Calculate the number of rounds needed to complete a 5 km run
                int rounds = ComputeRounds(perimeter, 5000);

                // Output the result
                Console.WriteLine($"\nThe athlete needs to complete {rounds} rounds to run 5 km.");
            }
            else
            {
                Console.WriteLine("\nThe entered sides do not form a valid triangle. Please try again.");
            }
        }

        // Method to compute the perimeter of the triangle
        static double ComputePerimeter(double a, double b, double c)
        {
            // Check if the sides form a valid triangle (triangle inequality)
            if (a + b > c && a + c > b && b + c > a)
            {
                return a + b + c;
            }
            return -1; // Return -1 for invalid triangle
        }

        // Method to compute the number of rounds
        static int ComputeRounds(double perimeter, double totalDistance)
        {
            return (int)Math.Ceiling(totalDistance / perimeter);
        }
    }
}

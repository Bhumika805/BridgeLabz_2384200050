using System;

namespace PracticeProblem2
{         
    public class Quadratic
    {
        // Method to find the roots of the quadratic equation
        public double[] FindRoots(double a, double b, double c)
        {
            double delta = Math.Pow(b, 2) - 4 * a * c; // Calculate delta (discriminant)
            double[] roots = new double[2];

            // Check if delta is positive, zero, or negative
            if (delta > 0)
            {
                // Two real roots
                roots[0] = (-b + Math.Sqrt(delta)) / (2 * a); // First root
                roots[1] = (-b - Math.Sqrt(delta)) / (2 * a); // Second root
            }
            else if (delta == 0)
            {
                // One real root
                roots[0] = -b / (2 * a);
                roots[1] = roots[0]; // Since both roots are the same in this case
            }
            else
            {
                // No real roots
                return new double[0]; // Empty array to represent no real roots
            }

            return roots;
        }
    }

    class QuadraticEquation
    {
        public void Quadratic__Equation()
        {
            Quadratic quadratic = new Quadratic();

            // Take user input for a, b, and c
            Console.Write("Enter value for a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter value for b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter value for c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            // Find the roots
            double[] roots = quadratic.FindRoots(a, b, c);

            // Display the results
            if (roots.Length == 0)
            {
                Console.WriteLine("The equation has no real roots.");
            }
            else if (roots[0] == roots[1])
            {
                Console.WriteLine($"The equation has one real root: {roots[0]}");
            }
            else
            {
                Console.WriteLine($"The equation has two real roots: {roots[0]} and {roots[1]}");
            }
        }
    }
}

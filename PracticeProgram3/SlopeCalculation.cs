using System;

namespace PracticeProblem3
{
    class SlopeCalculation
    {
        // Method to find the Euclidean distance between two points
        public static double CalculateEuclideanDistance(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return distance;
        }

        // Method to find the equation of the line
        public static double[] FindLineEquation(double x1, double y1, double x2, double y2)
        {
            // Calculate the slope m
            double m = (y2 - y1) / (x2 - x1);

            // Calculate the y-intercept b
            double b = y1 - m * x1;

            // Return the slope and y-intercept as an array
            return new double[] { m, b };
        }

        // Input method to take user inputs
        public static void InputMethod()
        {
            Console.Write("Enter the coordinates of the first point (x1, y1): ");
            string[] point1 = Console.ReadLine().Split(',');
            double x1 = Convert.ToDouble(point1[0]);
            double y1 = Convert.ToDouble(point1[1]);

            Console.Write("Enter the coordinates of the second point (x2, y2): ");
            string[] point2 = Console.ReadLine().Split(',');
            double x2 = Convert.ToDouble(point2[0]);
            double y2 = Convert.ToDouble(point2[1]);

            // Calculate the Euclidean distance
            double distance = CalculateEuclideanDistance(x1, y1, x2, y2);
            Console.WriteLine($"The Euclidean distance between the points is: {distance}");

            // Find the equation of the line
            double[] equation = FindLineEquation(x1, y1, x2, y2);
            Console.WriteLine($"The equation of the line is: y = {equation[0]}x + {equation[1]}");
        }

        
       
    }
}

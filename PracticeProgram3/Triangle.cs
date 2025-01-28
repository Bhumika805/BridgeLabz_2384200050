using System;

namespace PracticeProblem3
{
    class Triangle
    {
        // Method to find if the three points are collinear using the slope formula
        public static bool ArePointsCollinearBySlope(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            // Calculate the slopes between points
            double slopeAB = (y2 - y1) / (x2 - x1);
            double slopeBC = (y3 - y2) / (x3 - x2);
            double slopeAC = (y3 - y1) / (x3 - x1);

            // Check if all slopes are equal
            return slopeAB == slopeBC && slopeBC == slopeAC;
        }

        // Method to find if the three points are collinear using the area of the triangle formula
        public static bool ArePointsCollinearByArea(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            // Calculate the area of the triangle formed by the three points
            double area = 0.5 * (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));

            // Points are collinear if the area is 0
            return area == 0;
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

            Console.Write("Enter the coordinates of the third point (x3, y3): ");
            string[] point3 = Console.ReadLine().Split(',');
            double x3 = Convert.ToDouble(point3[0]);
            double y3 = Convert.ToDouble(point3[1]);

            // Check if points are collinear using slope method
            bool isCollinearBySlope = ArePointsCollinearBySlope(x1, y1, x2, y2, x3, y3);
            Console.WriteLine("The points are collinear by slope method: " + isCollinearBySlope);

            // Check if points are collinear using area method
            bool isCollinearByArea = ArePointsCollinearByArea(x1, y1, x2, y2, x3, y3);
            Console.WriteLine("The points are collinear by area method: " + isCollinearByArea);
        }

        // Main method to run the program
        static void Main(string[] args)
        {
            InputMethod();
        }
    }
}

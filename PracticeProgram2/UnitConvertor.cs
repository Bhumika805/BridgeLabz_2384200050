using System;

namespace PracticeProblem2
{
    public static class UnitConvertor
    {
        // Method to convert yards to feet
        public static double ConvertYardsToFeet(double yards)
        {
            double yards2feet = 3;
            return yards * yards2feet;
        }

        // Method to convert feet to yards
        public static double ConvertFeetToYards(double feet)
        {
            double feet2yards = 0.333333;
            return feet * feet2yards;
        }

        // Method to convert meters to inches
        public static double ConvertMetersToInches(double meters)
        {
            double meters2inches = 39.3701;
            return meters * meters2inches;
        }

        // Method to convert inches to meters
        public static double ConvertInchesToMeters(double inches)
        {
            double inches2meters = 0.0254;
            return inches * inches2meters;
        }

        // Method to convert inches to centimeters
        public static double ConvertInchesToCentimeters(double inches)
        {
            double inches2cm = 2.54;
            return inches * inches2cm;
        }

        // Method to print example conversions
        public static void PrintConversions()
        {
            Console.WriteLine("Unit Conversion Utility:");

            // Example usage of the methods
            Console.WriteLine("1 Yard to Feet: " + ConvertYardsToFeet(1));
            Console.WriteLine("1 Foot to Yards: " + ConvertFeetToYards(1));
            Console.WriteLine("1 Meter to Inches: " + ConvertMetersToInches(1));
            Console.WriteLine("1 Inch to Meters: " + ConvertInchesToMeters(1));
            Console.WriteLine("1 Inch to Centimeters: " + ConvertInchesToCentimeters(1));
        }
    }
}

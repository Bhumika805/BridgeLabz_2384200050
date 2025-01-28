using System;

namespace PracticeProblem2
{
    public static class UnitConverter
    {
        // Method to convert kilometers to miles
        public static double ConvertKmToMiles(double km)
        {
            double km2miles = 0.621371;
            return km * km2miles;
        }

        // Method to convert miles to kilometers
        public static double ConvertMilesToKm(double miles)
        {
            double miles2km = 1.60934;
            return miles * miles2km;
        }

        // Method to convert meters to feet
        public static double ConvertMetersToFeet(double meters)
        {
            double meters2feet = 3.28084;
            return meters * meters2feet;
        }

        // Method to convert feet to meters
        public static double ConvertFeetToMeters(double feet)
        {
            double feet2meters = 0.3048;
            return feet * feet2meters;
        }
    }

    class UnitConversionUtility
    {
        public void ConversionUtility()
        {
            // Example usage of the UnitConverter class

            // Convert Kilometers to Miles
            Console.Write("Enter distance in kilometers: ");
            double km = Convert.ToDouble(Console.ReadLine());
            double miles = UnitConverter.ConvertKmToMiles(km);
            Console.WriteLine($"{km} kilometers is equal to {miles:F2} miles.");

            // Convert Miles to Kilometers
            Console.Write("\nEnter distance in miles: ");
            double milesInput = Convert.ToDouble(Console.ReadLine());
            double kmConverted = UnitConverter.ConvertMilesToKm(milesInput);
            Console.WriteLine($"{milesInput} miles is equal to {kmConverted:F2} kilometers.");

            // Convert Meters to Feet
            Console.Write("\nEnter distance in meters: ");
            double meters = Convert.ToDouble(Console.ReadLine());
            double feet = UnitConverter.ConvertMetersToFeet(meters);
            Console.WriteLine($"{meters} meters is equal to {feet:F2} feet.");

            // Convert Feet to Meters
            Console.Write("\nEnter distance in feet: ");
            double feetInput = Convert.ToDouble(Console.ReadLine());
            double metersConverted = UnitConverter.ConvertFeetToMeters(feetInput);
            Console.WriteLine($"{feetInput} feet is equal to {metersConverted:F2} meters.");
        }
    }
}

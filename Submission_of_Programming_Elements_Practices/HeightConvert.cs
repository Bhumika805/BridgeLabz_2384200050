using System;

namespace Submission_of_Programming_Elements_Practices
{
    // Class to convert height from centimeters to feet and inches
    class HeightConvert
    {
        public void ConvertHeight()
        {
            // Prompt the user to enter height in centimeters
            Console.WriteLine("Enter your height in cm:");
            int heightCm = Convert.ToInt32(Console.ReadLine());

            // Convert height to inches and feet
            double totalInches = heightCm / 2.54; // 1 inch = 2.54 cm
            double feet = totalInches / 12;      // 1 foot = 12 inches

            // Display the height in different units
            Console.WriteLine($"Your height in cm is {heightCm:F2}, in feet is {feet:F2}, and in inches is {totalInches:F2}");
        }
    }
}

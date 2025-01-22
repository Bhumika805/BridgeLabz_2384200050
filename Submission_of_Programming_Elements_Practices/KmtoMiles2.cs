using System;

namespace Submission_of_Programming_Elements_Practices
{
    // Class to convert kilometers to miles
    class KmtoMiles2
    {
        public void ConvertKmtoMiles2()
        {
            // Prompt the user to enter the distance in kilometers
            Console.Write("Enter the distance in kilometers: ");
            double km = Convert.ToDouble(Console.ReadLine());

            // Convert the distance from kilometers to miles (1 mile ≈ 1.6 kilometers)
            double miles = km / 1.6;

            // Display the result in miles
            Console.WriteLine($"The total miles is {miles:F2} miles for the given {km:F2} km.");
        }
    }
}

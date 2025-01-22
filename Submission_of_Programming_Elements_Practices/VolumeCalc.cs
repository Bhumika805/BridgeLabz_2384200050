using System;

namespace Submission_of_Programming_Elements_Practices
{
    // Class to calculate the volume of Earth in both cubic kilometers and cubic miles
    class VolumeCalc
    {
        public void ComputeVolume()
        {
            // Define the radius of Earth in kilometers
            double radiusKm = 6378;

            // Convert the radius from kilometers to miles (1 km ≈ 0.621371 miles)
            double radiusMiles = radiusKm * 0.621371;

            // Calculate the volume of Earth in cubic kilometers using the formula: V = (4/3)πr^3
            double volumeKm3 = (4 / 3) * Math.PI * Math.Pow(radiusKm, 3);

            // Calculate the volume of Earth in cubic miles using the same formula
            double volumeMiles3 = (4 / 3) * Math.PI * Math.Pow(radiusMiles, 3);

            // Display the volume in both cubic kilometers and cubic miles
            Console.WriteLine($"The volume of Earth in cubic kilometers is {volumeKm3:F2} and cubic miles is {volumeMiles3:F2}");
        }
    }
}

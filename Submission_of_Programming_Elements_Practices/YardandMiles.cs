using System;

namespace Submission_of_Programming_Elements_Practices
{
    // Class to convert feet into yards and miles
    class YardandMiles
    {
        public void ConvertYardfromCm()
        {
            // Prompt the user to enter the distance in feet
            Console.WriteLine("Enter your distance in feet:");
            int distance = Convert.ToInt32(Console.ReadLine());

            // Convert the distance from feet to yards (1 yard = 3 feet)
            double totalYards = distance / 3.0;

            // Convert the distance from yards to miles (1 mile = 1760 yards)
            double miles = totalYards / 1760.0;

            // Display the distance in yards and miles
            Console.WriteLine($"The distance is {totalYards:F2} yards and {miles:F2} miles for the given {distance:F2} feet.");
        }
    }
}

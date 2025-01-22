using System;

namespace Assignment_2
{
    class JourneyDetails
    {
        public void GetJourneyDetails()
        {
            // Get user input for name
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            name = name ?? "Unknown";  // Default to "Unknown" if null
            
            // Get user input for cities
            Console.Write("Enter the starting city: ");
            string fromCity = Console.ReadLine();
            fromCity = fromCity ?? "Unknown City";  // Default to "Unknown City" if null
            
            Console.Write("Enter the via city: ");
            string viaCity = Console.ReadLine();
            viaCity = viaCity ?? "Unknown City";  // Default to "Unknown City" if null
            
            Console.Write("Enter the destination city: ");
            string toCity = Console.ReadLine();
            toCity = toCity ?? "Unknown City";  // Default to "Unknown City" if null
            
            // Get user input for distances
            Console.Write("Enter the distance from starting city to via city (in miles): ");
            double fromToVia = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter the distance from via city to destination city (in miles): ");
            double viaToFinalCity = Convert.ToDouble(Console.ReadLine());
            
            // Get user input for time taken
            Console.Write("Enter the total time taken for the journey (in hours): ");
            double timeTaken = Convert.ToDouble(Console.ReadLine());
            
            // Calculate total distance and average speed
            double totalDistance = fromToVia + viaToFinalCity;
            double averageSpeed = totalDistance / timeTaken;
            
            // Display results
            Console.WriteLine($@"
			The results of the trip are:
            1. Traveler's Name: {name}
            2. Total Distance: {totalDistance:F2} miles
            3. Average Speed: {averageSpeed:F2} miles per hour
            ");
        }
    }
}

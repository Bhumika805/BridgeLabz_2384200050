using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ride_Hailing_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> rides = new List<Vehicle>
        {
            new Car(101, "John Doe", 15, "Downtown"),
            new Bike(102, "Alice Smith", 8, "City Center"),
            new Auto(103, "Bob Johnson", 12, "Suburb")
        };

            double distance = 10; // Distance in km

            RideHailingService rideService = new RideHailingService();
            rideService.ProcessRides(rides, distance);

            // GPS Functionality
            Console.WriteLine("Updating and Retrieving GPS Locations:\n");
            foreach (var ride in rides)
            {
                if (ride is IGPS gpsEnabledRide)
                {
                    Console.WriteLine(gpsEnabledRide.GetCurrentLocation());
                    gpsEnabledRide.UpdateLocation("New Destination");
                    Console.WriteLine();
                }
            }
        }
    }
}

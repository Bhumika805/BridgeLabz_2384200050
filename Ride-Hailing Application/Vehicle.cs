using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ride_Hailing_Application
{
    
    // Interface for GPS functionality
    interface IGPS
    {
        string GetCurrentLocation();
        void UpdateLocation(string newLocation);
    }

    // Abstract class defining common vehicle properties
    abstract class Vehicle
    {
        private int vehicleId;
        private string driverName;
        private double ratePerKm;

        public Vehicle(int vehicleId, string driverName, double ratePerKm)
        {
            this.vehicleId = vehicleId;
            this.driverName = driverName;
            this.ratePerKm = ratePerKm;
        }

        public int VehicleId { get { return vehicleId; } }
        public string DriverName { get { return driverName; } }
        public double RatePerKm { get { return ratePerKm; } }

        // Abstract method for fare calculation
        public abstract double CalculateFare(double distance);

        // Concrete method to get vehicle details
        public virtual void GetVehicleDetails()
        {
            Console.WriteLine($"Vehicle ID: {VehicleId}, Driver: {DriverName}, Rate: {RatePerKm:C} per km");
        }
    }

    // Car subclass implementing IGPS
    class Car : Vehicle, IGPS
    {
        private string currentLocation;

        public Car(int vehicleId, string driverName, double ratePerKm, string startLocation)
            : base(vehicleId, driverName, ratePerKm)
        {
            this.currentLocation = startLocation;
        }

        public override double CalculateFare(double distance)
        {
            return distance * RatePerKm;
        }

        public string GetCurrentLocation()
        {
            return $"Car's Current Location: {currentLocation}";
        }

        public void UpdateLocation(string newLocation)
        {
            currentLocation = newLocation;
            Console.WriteLine($"Car location updated to: {currentLocation}");
        }
    }

    // Bike subclass implementing IGPS
    class Bike : Vehicle, IGPS
    {
        private string currentLocation;

        public Bike(int vehicleId, string driverName, double ratePerKm, string startLocation)
            : base(vehicleId, driverName, ratePerKm)
        {
            this.currentLocation = startLocation;
        }

        public override double CalculateFare(double distance)
        {
            return distance * RatePerKm * 0.9; // 10% discount for bikes
        }

        public string GetCurrentLocation()
        {
            return $"Bike's Current Location: {currentLocation}";
        }

        public void UpdateLocation(string newLocation)
        {
            currentLocation = newLocation;
            Console.WriteLine($"Bike location updated to: {currentLocation}");
        }
    }

    // Auto subclass implementing IGPS
    class Auto : Vehicle, IGPS
    {
        private string currentLocation;

        public Auto(int vehicleId, string driverName, double ratePerKm, string startLocation)
            : base(vehicleId, driverName, ratePerKm)
        {
            this.currentLocation = startLocation;
        }

        public override double CalculateFare(double distance)
        {
            return distance * RatePerKm * 1.1; // 10% surcharge for autos
        }

        public string GetCurrentLocation()
        {
            return $"Auto's Current Location: {currentLocation}";
        }

        public void UpdateLocation(string newLocation)
        {
            currentLocation = newLocation;
            Console.WriteLine($"Auto location updated to: {currentLocation}");
        }
    }

    // Ride-hailing service class to process multiple vehicles dynamically
    class RideHailingService
    {
        public void ProcessRides(List<Vehicle> vehicles, double distance)
        {
            Console.WriteLine("Ride Details and Fare Calculation:\n");
            foreach (var ride in vehicles)
            {
                ride.GetVehicleDetails();
                Console.WriteLine($"Estimated Fare for {distance} km: {ride.CalculateFare(distance):C}\n");
            }
        }
    }
            
}

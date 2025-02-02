using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_classes
{
    class Vehicle
    {
        // Instance Variables
        private string ownerName;
        private string vehicleType;

        // Class Variable (Shared among all vehicles)
        private static double registrationFee = 100.0; // Default registration fee for all vehicles

        // Constructor to initialize vehicle details
        public Vehicle(string ownerName, string vehicleType)
        {
            this.ownerName = ownerName;
            this.vehicleType = vehicleType;
        }

        // Instance Method: DisplayVehicleDetails
        public void DisplayVehicleDetails()
        {
            Console.WriteLine($"\nOwner Name: {ownerName}");
            Console.WriteLine($"Vehicle Type: {vehicleType}");
            Console.WriteLine($"Registration Fee: ${registrationFee}");
        }

        // Class Method: UpdateRegistrationFee (Static method to update the registration fee)
        public static void UpdateRegistrationFee(double newFee)
        {
            registrationFee = newFee; // Modify the class variable
            Console.WriteLine($"\nRegistration fee has been updated to: ${registrationFee}");
        }
    }
}

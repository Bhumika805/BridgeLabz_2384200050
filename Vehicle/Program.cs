using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    internal class Program
    {
        static void Main()
        {
            List<Vehicle> vehicles = new List<Vehicle>
        {
            new Car("CAR123", 1000, "CAR-INS-001"),
            new Bike("BIKE456", 500, "BIKE-INS-002"),
            new Truck("TRUCK789", 2000)
        };

            int rentalDays = 5;
            Console.WriteLine($"Vehicle Rental Costs for {rentalDays} days:\n");

            foreach (var vehicle in vehicles)
            {
                vehicle.DisplayDetails();

                double rentalCost = vehicle.CalculateRentalCost(rentalDays);
                Console.WriteLine($"Rental Cost for {rentalDays} days: {rentalCost:C}");

                if (vehicle is IInsurable insurableVehicle)
                {
                    Console.WriteLine(insurableVehicle.GetInsuranceDetails());
                }

                Console.WriteLine();
            }
        }
    }
}

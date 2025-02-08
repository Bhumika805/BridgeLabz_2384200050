using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Problems
{
    class Vehicle
        {
            public int MaxSpeed { get; set; }
            public string FuelType { get; set; }

            public Vehicle(int maxSpeed, string fuelType)
            {
                MaxSpeed = maxSpeed;
                FuelType = fuelType;
            }

            public virtual void DisplayInfo()
            {
                Console.WriteLine($"Max Speed: {MaxSpeed} km/h");
                Console.WriteLine($"Fuel Type: {FuelType}");
            }
        }

        // Subclass: Car
        class Car : Vehicle
        {
            public int SeatCapacity { get; set; }

            public Car(int maxSpeed, string fuelType, int seatCapacity) : base(maxSpeed, fuelType)
            {
                SeatCapacity = seatCapacity;
            }

            public override void DisplayInfo()
            {
                Console.WriteLine("Car Details:");
                Console.WriteLine($"Max Speed: {MaxSpeed} km/h");
                Console.WriteLine($"Fuel Type: {FuelType}");
                Console.WriteLine($"Seat Capacity: {SeatCapacity}");
                Console.WriteLine("---------------------------");
            }
        }

        // Subclass: Truck
        class Truck : Vehicle
        {
            public int PayloadCapacity { get; set; } // in kg

            public Truck(int maxSpeed, string fuelType, int payloadCapacity) : base(maxSpeed, fuelType)
            {
                PayloadCapacity = payloadCapacity;
            }

            public override void DisplayInfo()
            {
                Console.WriteLine("Truck Details:");
                Console.WriteLine($"Max Speed: {MaxSpeed} km/h");
                Console.WriteLine($"Fuel Type: {FuelType}");
                Console.WriteLine($"Payload Capacity: {PayloadCapacity} kg");
                Console.WriteLine("---------------------------");
            }
        }

        // Subclass: Motorcycle
        class Motorcycle : Vehicle
        {
            public bool HasSidecar { get; set; }

            public Motorcycle(int maxSpeed, string fuelType, bool hasSidecar) : base(maxSpeed, fuelType)
            {
                HasSidecar = hasSidecar;
            }

            public override void DisplayInfo()
            {
                Console.WriteLine("Motorcycle Details:");
                Console.WriteLine($"Max Speed: {MaxSpeed} km/h");
                Console.WriteLine($"Fuel Type: {FuelType}");
                Console.WriteLine($"Has Sidecar: {(HasSidecar ? "Yes" : "No")}");
                Console.WriteLine("---------------------------");
            }
        }
}



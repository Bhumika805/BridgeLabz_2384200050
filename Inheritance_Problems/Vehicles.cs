using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Problems
{
    // Base Class: Vehicles
    class Vehicles
    {
        public string Model { get; set; }
        public int MaxSpeed { get; set; }

        public Vehicles(string model, int maxSpeed)
        {
            Model = model;
            MaxSpeed = maxSpeed;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Max Speed: {MaxSpeed} km/h");
        }
    }

    // Interface: Refuelable (For Hybrid Inheritance)
    interface IRefuelable
    {
        void Refuel();
    }

    // Subclass: ElectricVehicle (Inherits from Vehicles)
    class ElectricVehicle : Vehicles
    {
        public int BatteryCapacity { get; set; } // in kWh

        public ElectricVehicle(string model, int maxSpeed, int batteryCapacity)
            : base(model, maxSpeed)
        {
            BatteryCapacity = batteryCapacity;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Battery Capacity: {BatteryCapacity} kWh");
        }

        public void Charge()
        {
            Console.WriteLine($"{Model} is charging its battery.");
        }
    }

    // Subclass: PetrolVehicle (Inherits from Vehicles & Implements IRefuelable)
    class PetrolVehicle : Vehicles, IRefuelable
    {
        public double FuelCapacity { get; set; } // in liters

        public PetrolVehicle(string model, int maxSpeed, double fuelCapacity)
            : base(model, maxSpeed)
        {
            FuelCapacity = fuelCapacity;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Fuel Capacity: {FuelCapacity} liters");
        }

        public void Refuel()
        {
            Console.WriteLine($"{Model} is refueling.");
        }
    }
}


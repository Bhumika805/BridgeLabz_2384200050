using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    interface IInsurable
    {
        double CalculateInsurance();
        string GetInsuranceDetails();
    }

    // Abstract class defining common vehicle properties
    abstract class Vehicle
    {
        private string vehicleNumber;
        private string type;
        private double rentalRate;

        public Vehicle(string vehicleNumber, string type, double rentalRate)
        {
            this.vehicleNumber = vehicleNumber;
            this.type = type;
            this.rentalRate = rentalRate;
        }

        public string VehicleNumber { get { return vehicleNumber; } }
        public string Type { get { return type; } }
        public double RentalRate { get { return rentalRate; } }

        // Abstract method to be implemented by subclasses
        public abstract double CalculateRentalCost(int days);

        // Method to display vehicle details
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Vehicle No: {VehicleNumber}, Type: {Type}, Rental Rate: {RentalRate:C}/day");
        }
    }

    // Car subclass implementing IInsurable
    class Car : Vehicle, IInsurable
    {
        private double insuranceRate = 0.05; // 5% of rental cost per day
        private string insurancePolicyNumber;

        public Car(string vehicleNumber, double rentalRate, string insurancePolicyNumber)
            : base(vehicleNumber, "Car", rentalRate)
        {
            this.insurancePolicyNumber = insurancePolicyNumber; // Encapsulation (not exposing policy number)
        }

        public override double CalculateRentalCost(int days)
        {
            return RentalRate * days;
        }

        public double CalculateInsurance()
        {
            return RentalRate * insuranceRate;
        }

        public string GetInsuranceDetails()
        {
            return $"Car Insurance Cost (5% per day): {CalculateInsurance():C}";
        }
    }

    // Bike subclass implementing IInsurable
    class Bike : Vehicle, IInsurable
    {
        private double insuranceRate = 0.02; // 2% of rental cost per day
        private string insurancePolicyNumber;

        public Bike(string vehicleNumber, double rentalRate, string insurancePolicyNumber)
            : base(vehicleNumber, "Bike", rentalRate)
        {
            this.insurancePolicyNumber = insurancePolicyNumber;
        }

        public override double CalculateRentalCost(int days)
        {
            return RentalRate * days;
        }

        public double CalculateInsurance()
        {
            return RentalRate * insuranceRate;
        }

        public string GetInsuranceDetails()
        {
            return $"Bike Insurance Cost (2% per day): {CalculateInsurance():C}";
        }
    }

    // Truck subclass (higher rental rate, no insurance)
    class Truck : Vehicle
    {
        public Truck(string vehicleNumber, double rentalRate)
            : base(vehicleNumber, "Truck", rentalRate)
        {
        }

        public override double CalculateRentalCost(int days)
        {
            return RentalRate * days * 1.2; // Extra 20% charge for heavy vehicles
        }
    }

}

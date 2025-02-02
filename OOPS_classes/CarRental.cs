using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_classes
{
    class CarRental
    {
        private string customerName;
        private string carModel;
        private int rentalDays;
        private double rentalCostPerDay;
        private double totalCost;

        // Default Constructor (initializes with default values)
        public CarRental()
        {
            customerName = "Unknown";
            carModel = "Standard";
            rentalDays = 1;
            rentalCostPerDay = 50.0; // Example rental cost per day
            totalCost = rentalDays * rentalCostPerDay;
        }

        // Parameterized Constructor (initializes with user-provided values)
        public CarRental(string customerName, string carModel, int rentalDays, double rentalCostPerDay = 50.0)
        {
            this.customerName = customerName;
            this.carModel = carModel;
            this.rentalDays = rentalDays;
            this.rentalCostPerDay = rentalCostPerDay;
            CalculateTotalCost();
        }

        // Method to calculate total rental cost
        private void CalculateTotalCost()
        {
            totalCost = rentalDays * rentalCostPerDay;
        }

        // Method to display rental details
        public void DisplayRentalDetails()
        {
            Console.WriteLine($"\nRental Details for {customerName}:");
            Console.WriteLine($"Car Model: {carModel}");
            Console.WriteLine($"Rental Days: {rentalDays}");
            Console.WriteLine($"Rental Cost Per Day: ${rentalCostPerDay}");
            Console.WriteLine($"Total Rental Cost: ${totalCost}");
        }
    }

}

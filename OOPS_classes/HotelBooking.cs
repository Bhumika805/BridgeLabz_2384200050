using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_classes
{
    class HotelBooking
    {
        private string guestName;
        private string roomType;
        private int nights;

        // Default Constructor (initializes with default values)
        public HotelBooking()
        {
            guestName = "Guest";
            roomType = "Standard";
            nights = 1;
        }

        // Parameterized Constructor (initializes with user-provided values)
        public HotelBooking(string guestName, string roomType, int nights)
        {
            this.guestName = guestName;
            this.roomType = roomType;
            this.nights = nights > 0 ? nights : 1; // Ensure valid number of nights
        }

        // Copy Constructor (clones another booking)
        public HotelBooking(HotelBooking other)
        {
            this.guestName = other.guestName;
            this.roomType = other.roomType;
            this.nights = other.nights;
        }

        // Method to display booking details
        public void DisplayBookingDetails()
        {
            Console.WriteLine($"Guest Name: {guestName}");
            Console.WriteLine($"Room Type: {roomType}");
            Console.WriteLine($"Nights: {nights}");
        }

        // Static method to take user input for booking details
        public static HotelBooking GetBookingDetails()
        {
            Console.Write("Enter guest name: ");
            string guestName = Console.ReadLine();

            Console.Write("Enter room type (Standard/Deluxe/Suite): ");
            string roomType = Console.ReadLine();

            int nights = -1;
            while (nights <= 0)
            {
                Console.Write("Enter number of nights: ");
                string input = Console.ReadLine();

                bool isValid = true;
                foreach (char c in input)
                {
                    if (!char.IsDigit(c))
                    {
                        isValid = false;
                        break;
                    }
                }

                if (isValid && input.Length > 0)
                {
                    nights = Convert.ToInt32(input);
                    if (nights <= 0)
                    {
                        Console.WriteLine("Nights must be greater than zero.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number of nights.");
                }
            }

            return new HotelBooking(guestName, roomType, nights);
        }
    }

}

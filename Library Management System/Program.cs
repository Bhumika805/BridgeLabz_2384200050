using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<LibraryItem> libraryItems = new List<LibraryItem>
        {
            new Book("B001", "The Great Gatsby", "F. Scott Fitzgerald"),
            new Magazine("M001", "National Geographic", "Various"),
            new DVD("D001", "Inception", "Christopher Nolan")
        };

            Console.WriteLine("Library Item Details and Loan Durations:\n");

            foreach (var item in libraryItems)
            {
                item.GetItemDetails();
                Console.WriteLine($"Loan Duration: {item.GetLoanDuration()} days\n");
            }

            // Demonstrating reservation
            Console.WriteLine("Reserving items:\n");
            foreach (var item in libraryItems)
            {
                if (item is IReservable reservableItem)
                {
                    reservableItem.ReserveItem("John Doe");
                }
            }

            Console.WriteLine("\nUpdated Availability Status:\n");
            foreach (var item in libraryItems)
            {
                item.GetItemDetails();
            }
        }
    }
}

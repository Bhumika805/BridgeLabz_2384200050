using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_classes
{
    class LibraryBook
    {
        private string title;
        private string author;
        private double price;
        private bool availability; // true if available, false if borrowed

        // Constructor to initialize the book details
        public LibraryBook(string title, string author, double price)
        {
            this.title = title;
            this.author = author;
            this.price = price;
            this.availability = true; // By default, a book is available
        }

        // Method to display book details
        public void DisplayBookDetails()
        {
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"Price: ${price}");
            Console.WriteLine($"Availability: {(availability ? "Available" : "Not Available")}");
        }

        // Method to borrow the book
        public void BorrowBook()
        {
            if (availability)
            {
                availability = false; // Mark the book as borrowed
                Console.WriteLine($"You have successfully borrowed '{title}'.");
            }
            else
            {
                Console.WriteLine($"Sorry, '{title}' is already borrowed.");
            }
        }

        // Method to return the book (restores availability)
        public void ReturnBook()
        {
            availability = true;
            Console.WriteLine($"Thank you for returning '{title}'.");
        }
    }
}

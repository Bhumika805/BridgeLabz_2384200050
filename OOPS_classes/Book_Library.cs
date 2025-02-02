using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_classes
{
    class Book_Library
    {
        // Public attribute: Can be accessed from anywhere
        public string ISBN;

        // Protected attribute: Accessible in derived classes
        protected string title;

        // Private attribute: Only accessible inside this class
        private string author;

        // Constructor to initialize book details
        public Book_Library(string ISBN, string title, string author)
        {
            this.ISBN = ISBN;
            this.title = title;
            this.author = author;
        }

        // Public method to set the author (required to modify the private attribute)
        public void SetAuthor(string newAuthor)
        {
            author = newAuthor;
        }

        // Public method to get the author (required to access the private attribute)
        public string GetAuthor()
        {
            return author;
        }

        // Method to display book details
        public void DisplayBookDetails()
        {
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Author: {author}");
        }
    }

    // Derived class: EBook
    class EBook : Book_Library
    {
        private double fileSizeMB; // Additional attribute for EBook

        // Constructor for EBook
        public EBook(string ISBN, string title, string author, double fileSizeMB)
            : base(ISBN, title, author)
        {
            this.fileSizeMB = fileSizeMB;
        }

        // Method to display EBook details (demonstrating access modifiers)
        public void DisplayEBookDetails()
        {
            Console.WriteLine("\nE-Book Details:");
            Console.WriteLine($"ISBN: {ISBN}");  // Accessible (public)
            Console.WriteLine($"Title: {title}");  // Accessible (protected in base class)
            Console.WriteLine($"File Size: {fileSizeMB} MB");
        }
    }

}

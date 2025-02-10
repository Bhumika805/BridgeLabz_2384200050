using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    interface IReservable
    {
        void ReserveItem(string borrowerName);
        bool CheckAvailability();
    }

    // Abstract class defining common library item properties
    abstract class LibraryItem
    {
        private string itemId;
        private string title;
        private string author;
        private bool isAvailable = true;
        private string borrowerName; // Encapsulated borrower information

        public LibraryItem(string itemId, string title, string author)
        {
            this.itemId = itemId;
            this.title = title;
            this.author = author;
        }

        public string ItemId { get { return itemId; } }
        public string Title { get { return title; } }
        public string Author { get { return author; } }
        public bool IsAvailable { get { return isAvailable; } }

        // Securely handle borrower details
        protected void SetBorrower(string borrower)
        {
            borrowerName = borrower;
            isAvailable = false;
        }

        protected void ClearBorrower()
        {
            borrowerName = null;
            isAvailable = true;
        }

        // Abstract method for loan duration
        public abstract int GetLoanDuration();

        // Concrete method to get item details
        public virtual void GetItemDetails()
        {
            Console.WriteLine($"ID: {ItemId}, Title: {Title}, Author: {Author}, Available: {IsAvailable}");
        }
    }

    // Book subclass implementing IReservable
    class Book : LibraryItem, IReservable
    {
        public Book(string itemId, string title, string author)
            : base(itemId, title, author) { }

        public override int GetLoanDuration()
        {
            return 14; // 14 days loan duration for books
        }

        public void ReserveItem(string borrowerName)
        {
            if (CheckAvailability())
            {
                SetBorrower(borrowerName);
                Console.WriteLine($"{Title} has been reserved by {borrowerName}.");
            }
            else
            {
                Console.WriteLine($"{Title} is not available for reservation.");
            }
        }

        public bool CheckAvailability()
        {
            return IsAvailable;
        }
    }

    // Magazine subclass implementing IReservable
    class Magazine : LibraryItem, IReservable
    {
        public Magazine(string itemId, string title, string author)
            : base(itemId, title, author) { }

        public override int GetLoanDuration()
        {
            return 7; // 7 days loan duration for magazines
        }

        public void ReserveItem(string borrowerName)
        {
            if (CheckAvailability())
            {
                SetBorrower(borrowerName);
                Console.WriteLine($"{Title} has been reserved by {borrowerName}.");
            }
            else
            {
                Console.WriteLine($"{Title} is not available for reservation.");
            }
        }

        public bool CheckAvailability()
        {
            return IsAvailable;
        }
    }

    // DVD subclass (Loan duration is shorter)
    class DVD : LibraryItem, IReservable
    {
        public DVD(string itemId, string title, string author)
            : base(itemId, title, author) { }

        public override int GetLoanDuration()
        {
            return 5; // 5 days loan duration for DVDs
        }

        public void ReserveItem(string borrowerName)
        {
            if (CheckAvailability())
            {
                SetBorrower(borrowerName);
                Console.WriteLine($"{Title} has been reserved by {borrowerName}.");
            }
            else
            {
                Console.WriteLine($"{Title} is not available for reservation.");
            }
        }

        public bool CheckAvailability()
        {
            return IsAvailable;
        }
    }
}

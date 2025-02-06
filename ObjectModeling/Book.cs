using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectModeling
{
    internal class Book
    {
        private string title;
        private string author;

        // constructor to initialize book attributes
        public Book(string title, string author)
        {
            this.title = title; 
            this.author = author;
        }

        //getter methods to access book details
        public string GetTitle() => title;
        public string GetAuthor() => author;

        //method to display book details
        public void DisplayBook()
        {
            Console.WriteLine($"Title: {title}, Author: {author}");
        }
    }

    //Library class (Aggregates multiple book objects)
    class Library
    {
        private List<Book> books;    // aggregation: Library contains a list of books

        //constructor initializes the book collection
        public Library()
        {
            books = new List<Book>();
        }

        //method to add a book to the library
        public void AddBook(Book book)
        {
            books.Add(book);   //adding a book to the collection
        }

        //method to display all books in the library
        public void DisplayBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books in the Library.");
                return;
            }

            Console.WriteLine("Books in the Library:");
            foreach(var book in books)
            {
                book.DisplayBook(); //display each book in the collection
            }
        }
    }

    class Library_Book
    {
        static void Main()
        {
            // creating independent book objects
            Book book1 = new Book("We should Do", "Bhumika Sharma");
            Book book2 = new Book("Create your own Opportunities", "Bhumika Sharma");

            //creating two different libraries
            Library library1 = new Library();
            Library library2 = new Library();

            // adding books to the first library
            library1.AddBook(book1);
            library1.AddBook(book2);

            //adding the same book to another Library (Providing Aggregation)
            library2.AddBook(book2);

            //display books in the first library
            Console.WriteLine("Library 1: ");
            library1.DisplayBooks();

            // display books in the second library
            Console.WriteLine("\nLibrary 2: ");
            library2.DisplayBooks();

        }
    }

}

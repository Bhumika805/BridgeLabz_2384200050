using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Level1
{
    internal class Book
        {
            private static string LibraryName = "Central Library"; // Shared across all books
            public readonly string ISBN; // Readonly to ensure uniqueness
            private string Title;
            private string Author;
            private int ShelfNumber;
            private static Random random = new Random(); // Random generator for Shelf Number

            // Static method to display library name
            public static void DisplayLibraryName()
            {
                Console.WriteLine($"Welcome to {LibraryName}");
            }

            // Constructor initializes properties and assigns a random shelf number
            public Book(string title, string author, string isbn)
            {
                this.Title = title;
                this.Author = author;
                this.ISBN = isbn;
                this.ShelfNumber = random.Next(1, 101); // Assign a random shelf number between 1 and 100
            }

            // Method to display book details
            public void DisplayBookInfo()
            {
                if (this is Book)
                {
                    Console.WriteLine("\nBook Details:");
                    Console.WriteLine($"Title: {Title}");
                    Console.WriteLine($"Author: {Author}");
                    Console.WriteLine($"ISBN: {ISBN}");
                    Console.WriteLine($"Shelf Number: {ShelfNumber}");
                }
                else
                {
                    Console.WriteLine("Invalid book object.");
                }
            }

            // Getter methods to access private fields
            public string GetTitle() => Title;
        }

        class Library
        {
            private List<Book> books = new List<Book>(); // Store all books

            // Method to add a new book (used by librarian)
            public void AddBook()
            {
                Console.Write("Enter Book Title: ");
                string title = Console.ReadLine();

                Console.Write("Enter Author Name: ");
                string author = Console.ReadLine();

                Console.Write("Enter ISBN Number: ");
                string isbn = Console.ReadLine();

                Book newBook = new Book(title, author, isbn);
                books.Add(newBook);
                Console.WriteLine("\nBook added successfully!");
            }

            // Method to find a book
            public Book FindBook(string title)
            {
                return books.Find(book => book.GetTitle().Equals(title, StringComparison.OrdinalIgnoreCase));
            }

            // Main library system for students and librarians
            public void LibrarySystem()
            {
                Book.DisplayLibraryName();

                while (true)
                {
                    Console.WriteLine("\nLibrary Menu:");
                    Console.WriteLine("1. Search for a Book");
                    Console.WriteLine("2. Add a New Book (Librarian)");
                    Console.WriteLine("3. Display All Books");
                    Console.WriteLine("4. Exit");
                    Console.Write("Enter your choice (1-4): ");

                    int choice;
                    while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
                    {
                        Console.Write("Invalid choice! Enter a number between 1-4: ");
                    }

                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter Book Title to Search: ");
                            string searchTitle = Console.ReadLine();
                            Book book = FindBook(searchTitle);

                            if (book != null)
                            {
                                Console.WriteLine("\nBook Found!");
                                book.DisplayBookInfo();
                            }
                            else
                            {
                                Console.WriteLine("\nBook not found in the library.");
                                Console.Write("Do you want to request this book to be added? (yes/no): ");
                                string request = Console.ReadLine().ToLower();

                                if (request == "yes")
                                {
                                    Console.WriteLine("\nPlease provide the book details.");
                                    AddBook(); // Librarian adds the book
                                }
                            }
                            break;

                        case 2:
                            AddBook();
                            break;

                        case 3:
                            Console.WriteLine("\nAll Books in the Library:");
                            if (books.Count == 0)
                            {
                                Console.WriteLine("No books available.");
                            }
                            else
                            {
                                foreach (var b in books)
                                {
                                    b.DisplayBookInfo();
                                }
                            }
                            break;

                        case 4:
                            Console.WriteLine("\nThank you for visiting the library!");
                            return;
                    }
                }
            }
        }
    }


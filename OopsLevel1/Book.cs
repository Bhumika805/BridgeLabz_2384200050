using System;

namespace OOPSLevel1
{
    public class Book
    {
        private string title;
        private string author;
        private double price;

        public void InputDetails()
        {
            Console.Write("Enter Book Title: ");
            title = Console.ReadLine();
            
            Console.Write("Enter Author Name: ");
            author = Console.ReadLine();
            
            Console.Write("Enter Book Price: ");
            price = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayDetails()
        {
            Console.WriteLine("\nBook Details:");
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Price: " + price);
        }
    }
}
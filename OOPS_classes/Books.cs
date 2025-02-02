using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_classes
{
    internal class Books
    {
        private string title;
        private string author;
        private double price;

        //Parameterized Constructor
        public Books(string title, string author, double price) 
        {
            this.title = title;
            this.author = author;
            this.price = price; //ensure valid price
        }

        //method to display book details
        public void GetBookDisplay()
        {
            Console.WriteLine($"\nBoook Details:\nTitle: {title}\nAuthor: {author}\nPrice: {price}");
        }
    }

    class BookInput
    {
        // Method to take user input for book details
        public static Books GetBookDetails()
        {
            Console.WriteLine("Enter book title: ");
            string title = Console.ReadLine();

            Console.WriteLine("Enter author name: ");
            string author = Console.ReadLine();

            double price = -1;
            while(price <= 0)
            {
                Console.WriteLine("Enter book Price:");
                string input = Console.ReadLine();

                bool isNumber = true;
                foreach (char c in input)
                {
                    if (!char.IsDigit(c) && c!= '.')
                    {
                        isNumber = false;
                        break;
                    }
                }

                if(isNumber && input.Length > 0)
                {
                    price = Convert.ToDouble(input);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid price.");
                }
            }
            // Return a new Books object after collecting input
            return new Books(title, author, price);
        }
    }

}

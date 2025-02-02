using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_classes
{
    class Product
    {
        // Instance Variables
        private string productName;
        private double price;

        // Class Variable (Shared among all products)
        private static int totalProducts = 0;

        // Constructor to initialize product details
        public Product(string productName, double price)
        {
            this.productName = productName;
            this.price = price;
            totalProducts++; // Increment the total number of products whenever a new product is created
        }

        // Instance Method: DisplayProductDetails
        public void DisplayProductDetails()
        {
            Console.WriteLine($"Product Name: {productName}");
            Console.WriteLine($"Price: ${price}");
        }

        // Class Method: DisplayTotalProducts (Static method, can be called on the class itself)
        public static void DisplayTotalProducts()
        {
            Console.WriteLine($"Total Products Created: {totalProducts}");
        }

        // Static Method to Take Input
        public static Product GetProductInput()
        {
            Console.Write("Enter product name: ");
            string productName = Console.ReadLine();

            Console.Write("Enter product price: ");
            double price = Convert.ToDouble(Console.ReadLine());  // Assuming valid input, no validation is done

            // Create and return the product
            return new Product(productName, price);
        }

        // Static Method to Display Output
        public static void DisplayProductOutput(Product product)
        {
            Console.WriteLine("\nProduct Details:");
            product.DisplayProductDetails();
        }
    }

}

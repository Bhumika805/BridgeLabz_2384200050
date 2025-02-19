using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class ShoppingCart
    {
        private Dictionary<string, double> productPrices;  // Stores product prices
        private OrderedDictionary orderedCart;  // Maintains order of items added
        private SortedDictionary<double, List<string>> sortedCart; // Sorts items by price

        public ShoppingCart()
        {
            productPrices = new Dictionary<string, double>();
            orderedCart = new OrderedDictionary();
            sortedCart = new SortedDictionary<double, List<string>>();
        }

        // Add product to cart
        public void AddProduct(string product, double price)
        {
            productPrices[product] = price;

            // Maintain order of addition
            if (!orderedCart.Contains(product))
            {
                orderedCart.Add(product, price);
            }

            // Maintain sorted dictionary by price
            if (!sortedCart.ContainsKey(price))
            {
                sortedCart[price] = new List<string>();
            }
            sortedCart[price].Add(product);
        }

        // Display cart in order of addition
        public void DisplayOrderedCart()
        {
            Console.WriteLine("\nShopping Cart (Order of Addition):");
            foreach (DictionaryEntry entry in orderedCart)
            {
                Console.WriteLine($"{entry.Key}: ${entry.Value}");
            }
        }

        // Display cart sorted by price
        public void DisplaySortedCart()
        {
            Console.WriteLine("\nShopping Cart (Sorted by Price):");
            foreach (var entry in sortedCart)
            {
                foreach (var product in entry.Value)
                {
                    Console.WriteLine($"{product}: ${entry.Key}");
                }
            }
        }

        public void DisplayShoppingCart()
        {
            ShoppingCart cart = new ShoppingCart();

            // Adding products
            cart.AddProduct("Laptop", 999.99);
            cart.AddProduct("Mouse", 25.50);
            cart.AddProduct("Keyboard", 49.99);
            cart.AddProduct("Monitor", 199.99);
            cart.AddProduct("Headphones", 79.99);

            cart.DisplayOrderedCart();
            cart.DisplaySortedCart();
        }
    }

}

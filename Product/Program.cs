using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
            new Electronics(101, "Laptop", 50000),
            new Clothing(102, "Jacket", 2000),
            new Groceries(103, "Apples", 500)
            };

            Console.WriteLine("Product Details and Final Prices:\n");
            foreach (var product in products)
            {
                product.DisplayDetails();

                double discount = product.CalculateDiscount();
                double tax = (product is ITaxable taxableProduct) ? taxableProduct.CalculateTax() : 0;
                double finalPrice = product.Price + tax - discount;

                Console.WriteLine($"Discount: {discount:C}");
                if (product is ITaxable taxable) Console.WriteLine(taxable.GetTaxDetails());
                Console.WriteLine($"Final Price: {finalPrice:C}\n");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    interface ITaxable
    {
        double CalculateTax();
        string GetTaxDetails();
    }

    // Abstract class defining common product properties
    abstract class Product
    {
        private int productId;
        private string name;
        private double price;

        public Product(int productId, string name, double price)
        {
            this.productId = productId;
            this.name = name;
            this.price = price;
        }

        public int ProductId { get { return productId; } }
        public string Name { get { return name; } }
        public double Price { get { return price; } }

        // Setter method for price (Encapsulation)
        public void SetPrice(double newPrice)
        {
            if (newPrice > 0)
                price = newPrice;
            else
                Console.WriteLine("Price must be positive.");
        }

        // Abstract method for discount calculation
        public abstract double CalculateDiscount();

        // Method to display product details
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Product ID: {ProductId}, Name: {Name}, Price: {Price:C}");
        }
    }

    // Electronics category implementing ITaxable
    class Electronics : Product, ITaxable
    {
        private double discountRate = 0.10; // 10% discount
        private double taxRate = 0.18; // 18% tax

        public Electronics(int productId, string name, double price)
            : base(productId, name, price) { }

        public override double CalculateDiscount()
        {
            return Price * discountRate;
        }

        public double CalculateTax()
        {
            return Price * taxRate;
        }

        public string GetTaxDetails()
        {
            return $"Electronics Tax (18%): {CalculateTax():C}";
        }
    }

    // Clothing category implementing ITaxable
    class Clothing : Product, ITaxable
    {
        private double discountRate = 0.15; // 15% discount
        private double taxRate = 0.05; // 5% tax

        public Clothing(int productId, string name, double price)
            : base(productId, name, price) { }

        public override double CalculateDiscount()
        {
            return Price * discountRate;
        }

        public double CalculateTax()
        {
            return Price * taxRate;
        }

        public string GetTaxDetails()
        {
            return $"Clothing Tax (5%): {CalculateTax():C}";
        }
    }

    // Groceries category (No tax)
    class Groceries : Product
    {
        private double discountRate = 0.05; // 5% discount

        public Groceries(int productId, string name, double price)
            : base(productId, name, price) { }

        public override double CalculateDiscount()
        {
            return Price * discountRate;
        }
    }
}


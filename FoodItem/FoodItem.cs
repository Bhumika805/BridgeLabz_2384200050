using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodItem
{
    interface IDiscountable
    {
        void ApplyDiscount(double percentage);
        string GetDiscountDetails();
    }

    // Abstract class defining common food item properties
    abstract class FoodItem
    {
        private string itemName;
        private double price;
        private int quantity;

        public FoodItem(string itemName, double price, int quantity)
        {
            this.itemName = itemName;
            this.price = price;
            this.quantity = quantity;
        }

        public string ItemName { get { return itemName; } }
        public double Price { get { return price; } }
        public int Quantity { get { return quantity; } }

        // Abstract method for calculating total price
        public abstract double CalculateTotalPrice();

        // Concrete method to get item details
        public virtual void GetItemDetails()
        {
            Console.WriteLine($"Item: {ItemName}, Price: {Price:C}, Quantity: {Quantity}, Total: {CalculateTotalPrice():C}");
        }
    }

    // VegItem subclass implementing IDiscountable
    class VegItem : FoodItem, IDiscountable
    {
        private double taxRate = 0.05; // 5% tax
        private double discount = 0;

        public VegItem(string itemName, double price, int quantity)
            : base(itemName, price, quantity) { }

        public override double CalculateTotalPrice()
        {
            return (Price * Quantity) + (Price * Quantity * taxRate) - discount;
        }

        public void ApplyDiscount(double percentage)
        {
            discount = (Price * Quantity * percentage) / 100;
            Console.WriteLine($"Discount of {percentage}% applied to {ItemName}.");
        }

        public string GetDiscountDetails()
        {
            return $"Discount Applied: {discount:C}";
        }
    }

    // NonVegItem subclass implementing IDiscountable
    class NonVegItem : FoodItem, IDiscountable
    {
        private double taxRate = 0.10; // 10% tax
        private double serviceCharge = 2.5; // Fixed service charge
        private double discount = 0;

        public NonVegItem(string itemName, double price, int quantity)
            : base(itemName, price, quantity) { }

        public override double CalculateTotalPrice()
        {
            return (Price * Quantity) + (Price * Quantity * taxRate) + serviceCharge - discount;
        }

        public void ApplyDiscount(double percentage)
        {
            discount = (Price * Quantity * percentage) / 100;
            Console.WriteLine($"Discount of {percentage}% applied to {ItemName}.");
        }

        public string GetDiscountDetails()
        {
            return $"Discount Applied: {discount:C}";
        }
    }

    // Main class to demonstrate polymorphism
    class Program
    {
        static void Main()
        {
            List<FoodItem> order = new List<FoodItem>
        {
            new VegItem("Paneer Tikka", 150, 2),
            new NonVegItem("Chicken Biryani", 250, 1),
            new NonVegItem("Fish Curry", 300, 1)
        };

            Console.WriteLine("Order Details Before Discount:\n");
            foreach (var item in order)
            {
                item.GetItemDetails();
            }

            // Applying discount
            Console.WriteLine("\nApplying Discounts:\n");
            foreach (var item in order)
            {
                if (item is IDiscountable discountableItem)
                {
                    discountableItem.ApplyDiscount(10); // Applying a 10% discount
                }
            }

            Console.WriteLine("\nOrder Details After Discount:\n");
            foreach (var item in order)
            {
                item.GetItemDetails();
                if (item is IDiscountable discountableItem)
                {
                    Console.WriteLine(discountableItem.GetDiscountDetails());
                }
                Console.WriteLine();
            }
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsConcept
{
   
    abstract class WarehouseItem
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public WarehouseItem(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public abstract void DisplayInfo();
    }

    // Derived classes for different item types
    class Electronics : WarehouseItem
    {
        public string Brand { get; set; }

        public Electronics(string name, double price, string brand) : base(name, price)
        {
            Brand = brand;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Electronics - Name: {Name}, Price: {Price}, Brand: {Brand}");
        }
    }

    class Groceries : WarehouseItem
    {
        public DateTime ExpiryDate { get; set; }

        public Groceries(string name, double price, DateTime expiryDate) : base(name, price)
        {
            ExpiryDate = expiryDate;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Groceries - Name: {Name}, Price: {Price}, Expiry Date: {ExpiryDate.ToShortDateString()}");
        }
    }

    class Furniture : WarehouseItem
    {
        public string Material { get; set; }

        public Furniture(string name, double price, string material) : base(name, price)
        {
            Material = material;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Furniture - Name: {Name}, Price: {Price}, Material: {Material}");
        }
    }

    // Generic storage class with constraint
    class Storage<T> where T : WarehouseItem
    {
        private List<T> items = new List<T>();

        public void AddItem(T item)
        {
            items.Add(item);
        }

        public void DisplayAllItems()
        {
            foreach (var item in items)
            {
                item.DisplayInfo();
            }
        }
    }

    class Program1
    {
        public void ProgramMethod1()
        {
            // Create storage instances for different item types
            Storage<Electronics> electronicsStorage = new Storage<Electronics>();
            Storage<Groceries> groceriesStorage = new Storage<Groceries>();
            Storage<Furniture> furnitureStorage = new Storage<Furniture>();

            // Add items to storage
            electronicsStorage.AddItem(new Electronics("Laptop", 1200.50, "Dell"));
            electronicsStorage.AddItem(new Electronics("Smartphone", 800.99, "Samsung"));

            groceriesStorage.AddItem(new Groceries("Milk", 2.50, DateTime.Now.AddDays(10)));
            groceriesStorage.AddItem(new Groceries("Bread", 1.20, DateTime.Now.AddDays(3)));

            furnitureStorage.AddItem(new Furniture("Chair", 50.75, "Wood"));
            furnitureStorage.AddItem(new Furniture("Table", 150.99, "Metal"));

            // Display stored items
            Console.WriteLine("\nElectronics:");
            electronicsStorage.DisplayAllItems();

            Console.WriteLine("\nGroceries:");
            groceriesStorage.DisplayAllItems();

            Console.WriteLine("\nFurniture:");
            furnitureStorage.DisplayAllItems();
        }
    }

}

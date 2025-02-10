using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodItem
{
    internal class Program
    {
        static void Main(string[] args)
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

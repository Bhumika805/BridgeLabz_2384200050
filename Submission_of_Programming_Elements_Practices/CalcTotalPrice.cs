using System;

namespace Submission_of_Programming_Elements_Practices
{
    // Class to calculate the total price of an item based on unit price and quantity
    class CalcTotalPrice
    {
        public void CalcPrice()
        {
            // Prompt the user to enter the unit price of the item in INR
            Console.Write("Enter the unit price of the item in INR: ");
            double unitPrice = Convert.ToDouble(Console.ReadLine());

            // Prompt the user to enter the quantity of the item to be bought
            Console.Write("Enter the quantity to be bought: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            // Calculate the total price based on unit price and quantity
            double totalPrice = unitPrice * quantity;

            // Display the total price along with the unit price and quantity
            Console.WriteLine($"The total purchase price is INR {totalPrice:F2} if the quantity is {quantity} and unit price is INR {unitPrice:F2}.");
        }
    }
}

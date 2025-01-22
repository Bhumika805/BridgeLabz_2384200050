using System;

namespace Submission_of_Programming_Elements_Practices
{
    // Class to calculate the profit and profit percentage based on cost and selling prices
    class ProfitCalc
    {
        public void CalculateProfit()
        {
            // Define the cost price and selling price
            int costPrice = 129;
            int sellingPrice = 191;

            // Calculate the profit by subtracting cost price from selling price
            int profit = sellingPrice - costPrice;

            // Calculate the profit percentage based on the cost price
            double profitPercentage = (double)profit / costPrice * 100;

            // Display the cost price, selling price, profit, and profit percentage
            Console.WriteLine($@"
                The Cost Price is INR {costPrice} and Selling Price is INR {sellingPrice}
                The Profit is INR {profit} and the Profit Percentage is {profitPercentage:F2}%
            ");
        }
    }
}

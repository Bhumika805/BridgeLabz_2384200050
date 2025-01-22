using System;

namespace Assignment_2
{
	class IncomeCalculator
	{
		public void totalincomecalculator()
		{
			// Input: Take salary and bonus from the user
            Console.Write("Enter your salary (INR): ");
            double salary = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your bonus (INR): ");
            double bonus = Convert.ToDouble(Console.ReadLine());

            // Calculate total income
            double totalIncome = salary + bonus;

           // Output: Print the results
           Console.WriteLine($"The salary is INR {salary} and bonus is INR {bonus}. Hence Total Income is INR {totalIncome}.");
		}
    }
}

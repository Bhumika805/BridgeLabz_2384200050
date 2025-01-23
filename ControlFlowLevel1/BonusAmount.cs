using System;

namespace ControlFlowLevel1
{
	class BonusAmount
	{
		public void Bonus()
		{
			Console.Write("Enter the employee's salary: ");
			double salary = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the employee's years of service: ");
            int yearsOfService = Convert.ToInt32(Console.ReadLine());

            // Check if years of service are more than 5
            double bonus = 0;
			if (yearsOfService > 5)
			{
				bonus = salary * 0.05; // 5% bonus
			}

             // Print the bonus amount
             Console.WriteLine("The bonus amount is: " + bonus);
        }
    }
}

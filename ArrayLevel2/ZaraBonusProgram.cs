using System;

namespace ArrayLevel2
{
    class ZaraBonusProgram
    {
        public void BonusProgram()
        {
            const int employeeCount = 10; // Number of employees
            const double highBonusRate = 0.05; // 5% bonus for more than 5 years
            const double lowBonusRate = 0.02; // 2% bonus for 5 years or less

            // Arrays to store data
            double[] salaries = new double[employeeCount];
            int[] yearsOfService = new int[employeeCount];
            double[] bonuses = new double[employeeCount];
            double[] newSalaries = new double[employeeCount];

            double totalBonus = 0; // Total bonus amount
            double totalOldSalary = 0; // Total old salary
            double totalNewSalary = 0; // Total new salary

            // Input salary and years of service for each employee
            for (int i = 0; i < employeeCount; i++)
            {
                Console.WriteLine($"\nEnter details for Employee {i + 1}:");

                // Input salary
                Console.Write("Enter salary: ");
                salaries[i] = Convert.ToDouble(Console.ReadLine());
                totalOldSalary += salaries[i]; // Add to total old salary

                // Input years of service
                Console.Write("Enter years of service: ");
                yearsOfService[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Calculate bonus and new salary for each employee
            for (int i = 0; i < employeeCount; i++)
            {
                // Check years of service to determine bonus
                if (yearsOfService[i] > 5)
                    bonuses[i] = salaries[i] * highBonusRate; // 5% bonus
                else
                    bonuses[i] = salaries[i] * lowBonusRate; // 2% bonus

                // Calculate new salary
                newSalaries[i] = salaries[i] + bonuses[i];

                // Update total bonus and total new salary
                totalBonus += bonuses[i];
                totalNewSalary += newSalaries[i];
            }

            // Display bonus and salary details for each employee
            Console.WriteLine("\nEmployee Bonus and Salary Details:");
            for (int i = 0; i < employeeCount; i++)
            {
                Console.WriteLine($"Employee {i + 1}: Old Salary = {salaries[i]:C}, Bonus = {bonuses[i]:C}, New Salary = {newSalaries[i]:C}");
            }

            // Display totals
            Console.WriteLine($"\nTotal Bonus Paid: {totalBonus:C}");
            Console.WriteLine($"Total Old Salary: {totalOldSalary:C}");
            Console.WriteLine($"Total New Salary: {totalNewSalary:C}");
        }
    }
}

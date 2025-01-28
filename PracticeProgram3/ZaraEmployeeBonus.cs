using System;

namespace PracticeProblem3
{
    class ZaraEmployeeBonus
    {
        // Method to determine the salary and years of service
        public static double[,] DetermineSalaryAndYearsOfService(int numEmployees)
        {
            Random rand = new Random();
            double[,] employeeData = new double[numEmployees, 2]; // 2D array for Salary and Years of Service

            for (int i = 0; i < numEmployees; i++)
            {
                employeeData[i, 0] = rand.Next(30000, 100000);  // Random salary between 30,000 and 100,000
                employeeData[i, 1] = rand.Next(1, 21);  // Random years of service between 1 and 20
            }

            return employeeData;
        }

        // Method to calculate new salary and bonus
        public static double[,] CalculateNewSalaryAndBonus(double[,] employeeData, int numEmployees)
        {
            double[,] updatedEmployeeData = new double[numEmployees, 3]; // 2D array for Old Salary, New Salary, Bonus

            for (int i = 0; i < numEmployees; i++)
            {
                double oldSalary = employeeData[i, 0];
                int yearsOfService = (int)employeeData[i, 1];

                // Calculate Bonus and New Salary
                double bonusPercentage = (yearsOfService >= 5) ? 0.05 : 0.02;
                double bonus = oldSalary * bonusPercentage;
                double newSalary = oldSalary + bonus;

                // Store the old salary, new salary, and bonus
                updatedEmployeeData[i, 0] = oldSalary;
                updatedEmployeeData[i, 1] = newSalary;
                updatedEmployeeData[i, 2] = bonus;
            }

            return updatedEmployeeData;
        }

        // Method to calculate and display the sum of old salary, new salary, and total bonus amount
        public static void DisplayResults(double[,] updatedEmployeeData, int numEmployees)
        {
            double totalOldSalary = 0, totalNewSalary = 0, totalBonus = 0;

            Console.WriteLine("Employee Salary Details");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Emp No | Old Salary | New Salary | Bonus");

            for (int i = 0; i < numEmployees; i++)
            {
                double oldSalary = updatedEmployeeData[i, 0];
                double newSalary = updatedEmployeeData[i, 1];
                double bonus = updatedEmployeeData[i, 2];

                totalOldSalary += oldSalary;
                totalNewSalary += newSalary;
                totalBonus += bonus;

                Console.WriteLine($"{i + 1,-7} | {oldSalary,-10:C} | {newSalary,-10:C} | {bonus,-10:C}");
            }

            // Display the totals
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine($"Total Old Salary: {totalOldSalary:C}");
            Console.WriteLine($"Total New Salary: {totalNewSalary:C}");
            Console.WriteLine($"Total Bonus: {totalBonus:C}");
        }

        
        public void Input()
        {
            int numEmployees = Convert.ToInt32(Console.ReadLine()); // Number of employees

            // Step 1: Determine Salary and Years of Service
            double[,] employeeData = DetermineSalaryAndYearsOfService(numEmployees);

            // Step 2: Calculate New Salary and Bonus
            double[,] updatedEmployeeData = CalculateNewSalaryAndBonus(employeeData, numEmployees);

            // Step 3: Display the Results in a Tabular Format
            DisplayResults(updatedEmployeeData, numEmployees);
        }
    }
}

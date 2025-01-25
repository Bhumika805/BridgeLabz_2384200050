using System;

namespace ArrayLevel2  
{
    class BMI_Calculator
    {
        public void CheckBMICalculator()
        {
            Console.Write("Enter the number of persons: ");
            int numOfPersons = Convert.ToInt32(Console.ReadLine());

            // Create arrays to store weight, height, BMI, and status of persons
            double[] height = new double[numOfPersons];
            double[] weight = new double[numOfPersons];
            double[] bmi = new double[numOfPersons];
            string[] status = new string[numOfPersons];

            // Take input for height and weight of each person
            for (int i = 0; i < numOfPersons; i++)
            {
                Console.WriteLine($"\nEnter details for person {i + 1}:");
                
                // Input height in meters and weight in kg
                Console.Write("Height (in meters): ");
                height[i] = Convert.ToDouble(Console.ReadLine());
                Console.Write("Weight (in kilograms): ");
                weight[i] = Convert.ToDouble(Console.ReadLine());

                // Calculate BMI
                bmi[i] = weight[i] / (height[i] * height[i]);

                // Determine weight status based on BMI
                if (bmi[i] <= 18.4)
                    status[i] = "Underweight";
                else if (bmi[i] >= 18.5 && bmi[i] <= 24.9)
                    status[i] = "Normal";
                else if (bmi[i] >= 25.0 && bmi[i] <= 39.9)
                    status[i] = "Overweight";
                else
                    status[i] = "Obese";
            }

            // Display the results
            Console.WriteLine("\nBMI Report:");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Person  | Height (m) | Weight (kg) | BMI     | Status");
            Console.WriteLine("-------------------------------------------------------------");

            for (int i = 0; i < numOfPersons; i++)
            {
                Console.WriteLine($"{i + 1,6}  | {height[i],10:F2} | {weight[i],12:F2} | {bmi[i],7:F2} | {status[i],12}");
            }

            Console.WriteLine("-------------------------------------------------------------");
        }
    }
}

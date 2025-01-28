using System;

namespace PracticeProblem2
{
    public class BMIAnalyzer
    {
        // Method to calculate BMI and populate the array
        public void CalculateBMI(double[,] data)
        {
            for (int i = 0; i < data.GetLength(0); i++)
            {
                double weight = data[i, 0];
                double heightInMeters = data[i, 1] / 100; // Convert height from cm to meters
                data[i, 2] = weight / (heightInMeters * heightInMeters); // Calculate BMI
            }
        }

        // Method to determine BMI status
        public string[] DetermineBMIStatus(double[,] data)
        {
            string[] statuses = new string[data.GetLength(0)];

            for (int i = 0; i < data.GetLength(0); i++)
            {
                double bmi = data[i, 2];

                if (bmi < 18.5)
                {
                    statuses[i] = "Underweight";
                }
                else if (bmi >= 18.5 && bmi < 24.9)
                {
                    statuses[i] = "Normal weight";
                }
                else if (bmi >= 25 && bmi < 29.9)
                {
                    statuses[i] = "Overweight";
                }
                else
                {
                    statuses[i] = "Obesity";
                }
            }

            return statuses;
        }
    }

    class BMIProgram
    {
        public void RunBMIProgram()
        {
            BMIAnalyzer analyzer = new BMIAnalyzer();
            double[,] data = new double[10, 3]; // Array for weight, height, and BMI
            string[] statuses;

            // Input weight and height for 10 individuals
            Console.WriteLine("Enter the weight (in kg) and height (in cm) for 10 individuals:");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"\nPerson {i + 1}:");
                Console.Write("Enter weight (kg): ");
                data[i, 0] = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter height (cm): ");
                data[i, 1] = Convert.ToDouble(Console.ReadLine());
            }

            // Calculate BMI
            analyzer.CalculateBMI(data);

            // Determine BMI statuses
            statuses = analyzer.DetermineBMIStatus(data);

            // Display the results
            Console.WriteLine("\nResults:");
            Console.WriteLine("Weight(kg) | Height(cm) | BMI       | Status");
            Console.WriteLine("-----------------------------------------------");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{data[i, 0],10} | {data[i, 1],10} | {data[i, 2],8:F2} | {statuses[i]}");
            }
        }
    }
}



using System;

namespace ArrayLevel2
{
    class MultiDimensional_BMI
    {
        public void BMI()
        {
            Console.Write("Enter the number of persons: ");
            int numberOfPersons = Convert.ToInt32(Console.ReadLine());

            // Create a 2D array to store weight, height, and BMI for each person
            double[][] personData = new double[numberOfPersons][];
            for (int i = 0; i < numberOfPersons; i++)
            {
                personData[i] = new double[3]; // Each person will have 3 values (height, weight, BMI)
            }

            // Array to store the weight status of each person
            string[] weightStatus = new string[numberOfPersons];

            // Take input for weight and height of each person
            for (int i = 0; i < numberOfPersons; i++)
            {
                Console.WriteLine($"\nEnter details for person {i + 1}:");

                // Input height (must be a positive value)
                double height;
                do
                {
                    Console.Write("Height (in meters): ");
                    height = Convert.ToDouble(Console.ReadLine());
                    if (height <= 0)
                    {
                        Console.WriteLine("Please enter a positive value for height.");
                    }
                } while (height <= 0);

                // Input weight (must be a positive value)
                double weight;
                do
                {
                    Console.Write("Weight (in kilograms): ");
                    weight = Convert.ToDouble(Console.ReadLine());
                    if (weight <= 0)
                    {
                        Console.WriteLine("Please enter a positive value for weight.");
                    }
                } while (weight <= 0);

                // Store height and weight in personData array
                personData[i][0] = height;
                personData[i][1] = weight;

                // Calculate BMI and store it in the personData array
                double bmi = weight / (height * height);
                personData[i][2] = bmi;

                // Determine weight status based on BMI
                if (bmi <= 18.4)
                    weightStatus[i] = "Underweight";
                else if (bmi >= 18.5 && bmi <= 24.9)
                    weightStatus[i] = "Normal";
                else if (bmi >= 25.0 && bmi <= 39.9)
                    weightStatus[i] = "Overweight";
                else
                    weightStatus[i] = "Obese";
            }

            // Display the results
            Console.WriteLine("\nBMI Report:");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Person  | Height (m) | Weight (kg) | BMI     | Status");
            Console.WriteLine("-------------------------------------------------------------");

            for (int i = 0; i < numberOfPersons; i++)
            {
                Console.WriteLine($"{i + 1,6}  | {personData[i][0],10:F2} | {personData[i][1],12:F2} | {personData[i][2],7:F2} | {weightStatus[i],12}");
            }

            Console.WriteLine("-------------------------------------------------------------");
        }
    }
}

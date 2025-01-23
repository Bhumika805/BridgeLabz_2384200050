using System;

namespace ControlFlowLevel2
{
    class BMI_Calculator
    {
        public void BMI_Calculation()
        {
            // Take user input for weight (kg) and height (cm)
            Console.Write("Enter weight in kg: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter height in cm: ");
            double heightInCm = Convert.ToDouble(Console.ReadLine());

            // Convert height from cm to meters
            double heightInMeters = heightInCm / 100;

            // Calculate BMI using the formula: BMI = weight / (height * height)
            double bmi = weight / (heightInMeters * heightInMeters);

            // Output the BMI
            Console.WriteLine("Your BMI is: " + bmi);

            // Determine the weight status based on BMI
            if (bmi <= 18.4)
            {
                Console.WriteLine("You are underweight.");
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                Console.WriteLine("You have a normal weight.");
            }
            else if (bmi >= 25.0 && bmi <= 39.9)
            {
                Console.WriteLine("You are overweight.");
            }
            else
            {
                Console.WriteLine("You are obese.");
            }
        }
    }
}

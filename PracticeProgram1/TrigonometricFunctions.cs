using System;

namespace PracticeProblem1
{
    class TrigonometricFunctions
    {
        public void Trigonometric__Functions()
        {
            // Prompt the user to enter an angle in degrees
            Console.Write("Enter the angle in degrees: ");
            double angle = Convert.ToDouble(Console.ReadLine());

            // Call the method to calculate trigonometric functions
            double[] results = CalculateTrigonometricFunctions(angle);

            // Display the results
            Console.WriteLine($"\nTrigonometric Functions for {angle}°:");
            Console.WriteLine($"Sine: {results[0]:F4}");
            Console.WriteLine($"Cosine: {results[1]:F4}");
            Console.WriteLine($"Tangent: {results[2]:F4}");
        }

        // Method to calculate sine, cosine, and tangent of an angle
        public static double[] CalculateTrigonometricFunctions(double angle)
        {
            // Convert the angle to radians
            double radians = Math.PI * angle / 180.0;

            // Calculate sine, cosine, and tangent
            double sine = Math.Sin(radians);
            double cosine = Math.Cos(radians);
            double tangent = Math.Tan(radians);

            // Return the results as an array
            return new double[] { sine, cosine, tangent };
        }
    }
}

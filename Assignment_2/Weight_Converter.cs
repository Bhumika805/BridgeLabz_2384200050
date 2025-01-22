using System;

namespace Assignment_2
{
    class Weight_Converter
    {
        public void Convert_Weight()
        {
            // Get input value for weight in pounds
            Console.Write("Enter the weight in pounds: ");
            double weightInPounds = Convert.ToDouble(Console.ReadLine());
            
            // Convert pounds to kilograms using the conversion factor
            double weightInKg = weightInPounds * 2.2;
            
            // Display the result
            Console.WriteLine($@"
            The weight of the person in pounds is {weightInPounds} and in kg is {weightInKg}.
            ");
        }
    }
}

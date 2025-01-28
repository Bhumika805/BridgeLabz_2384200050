using System;

namespace PracticeProblem1
{
    class DisplaySimpleInterest
    {
        public void CalculateAndDisplaySimpleInterest()
        {
            Console.Write("Enter the Principal amount: ");
            double principal = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Rate of Interest (in %): ");
            double rate = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Time (in years): ");
            double time = Convert.ToDouble(Console.ReadLine());

            // Call the method to calculate simple interest
            double simpleInterest = CalculateSimpleInterest(principal, rate, time);

            // Display the result
            Console.WriteLine($"The Simple Interest is {simpleInterest:F2} for Principal {principal}, Rate of Interest {rate}% and Time {time} years.");
        }

        // Method to calculate Simple Interest
        public double CalculateSimpleInterest(double principal, double rate, double time)
        {
            return (principal * rate * time) / 100;
        }
    }
}
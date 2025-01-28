using System;

namespace PracticeProblem1
{
    class WindChillCalculator
    {
        public void WindChill()
        {
            // Prompt the user for temperature and wind speed
            Console.Write("Enter the temperature in Fahrenheit: ");
            double temperature = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the wind speed in miles per hour: ");
            double windSpeed = Convert.ToDouble(Console.ReadLine());

            // Call the method to calculate the wind chill
            double windChill = CalculateWindChill(temperature, windSpeed);

            // Output the wind chill temperature
            Console.WriteLine($"\nThe wind chill temperature is: {windChill:F2}°F");
        }

        // Method to calculate the wind chill temperature using the formula
        public static double CalculateWindChill(double temperature, double windSpeed)
        {
            // Wind chill formula: windChill = 35.74 + 0.6215 * temp + (0.4275 * temp - 35.75) * windSpeed^0.16
            double windChill = 35.74 + 0.6215 * temperature + (0.4275 * temperature - 35.75) * Math.Pow(windSpeed, 0.16);
            return windChill;
        }
    }
}

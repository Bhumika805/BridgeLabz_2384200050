using System;

namespace BuiltInFunctions2
{
    public class TemperatureConverter
    {
        public void InputMethod()
        {
            Console.WriteLine("Enter temperature:");
            double temp = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Convert to (C)elsius or (F)ahrenheit?");
            char choice = Char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (choice == 'C')
                Console.WriteLine($"Converted: {FahrenheitToCelsius(temp)}°C");
            else if (choice == 'F')
                Console.WriteLine($"Converted: {CelsiusToFahrenheit(temp)}°F");
            else
                Console.WriteLine("Invalid choice.");
        }

        private double FahrenheitToCelsius(double f) => (f - 32) * 5 / 9;
        private double CelsiusToFahrenheit(double c) => (c * 9 / 5) + 32;
    }
}

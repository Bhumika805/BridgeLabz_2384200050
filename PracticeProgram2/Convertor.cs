using System;

namespace PracticeProblem2
{

public static class Convertor
{
    // Method to convert Fahrenheit to Celsius
    public static double ConvertFahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    // Method to convert Celsius to Fahrenheit
    public static double ConvertCelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    // Method to convert Pounds to Kilograms
    public static double ConvertPoundsToKilograms(double pounds)
    {
        return pounds * 0.453592;
    }

    // Method to convert Kilograms to Pounds
    public static double ConvertKilogramsToPounds(double kilograms)
    {
        return kilograms * 2.20462;
    }

    // Method to convert Gallons to Liters
    public static double ConvertGallonsToLiters(double gallons)
    {
        return gallons * 3.78541;
    }

    // Method to convert Liters to Gallons
    public static double ConvertLitersToGallons(double liters)
    {
        return liters * 0.264172;
    }


    // Main method to get user input and perform conversions
    public static void Converson()
    {
        Console.WriteLine("Enter the type of conversion you want to perform:");
        Console.WriteLine("1. Fahrenheit to Celsius");
        Console.WriteLine("2. Celsius to Fahrenheit");
        Console.WriteLine("3. Pounds to Kilograms");
        Console.WriteLine("4. Kilograms to Pounds");
        Console.WriteLine("5. Gallons to Liters");
        Console.WriteLine("6. Liters to Gallons");
        Console.Write("Enter your choice (1-6): ");
        int choice = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the value to convert: ");
        double input = Convert.ToDouble(Console.ReadLine());
        double result = 0;
        switch (choice)
        {
            case 1:
                result = ConvertFahrenheitToCelsius(input);
                Console.WriteLine($"{input} F = {result} C");
                break;
            case 2:
                result = ConvertCelsiusToFahrenheit(input);
                Console.WriteLine($"{input} C = {result} F");
                break;
            case 3:
                result = ConvertPoundsToKilograms(input);
                Console.WriteLine($"{input} lbs = {result} kg");
                break;
            case 4:
                result = ConvertKilogramsToPounds(input);
                Console.WriteLine($"{input} kg = {result} lbs");
                break;
            case 5:
                result = ConvertGallonsToLiters(input);
                Console.WriteLine($"{input} gallons = {result} liters");
                break;
            case 6:
                result = ConvertLitersToGallons(input);
                Console.WriteLine($"{input} liters = {result} gallons");
                break;
            default:
                Console.WriteLine("Invalid choice!");
                break;
        }
    }
}
}
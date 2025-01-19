using System;

class Program3
{
    static void Main(string[] args)
    {
       
        Console.Write("Enter the temperature in Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        double fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine("Celsius to Fahrenheit Conversion.", celsius, fahrenheit);
    }
}

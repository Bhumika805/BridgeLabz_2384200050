using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the distance in kilometers: ");
        int kilometers = Convert.ToInt32(Console.ReadLine());

        double miles = kilometers * 0.621371;

        Console.WriteLine("{0} kilometers is equal to {1:F2} miles.", kilometers, miles);
    }
}

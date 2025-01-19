using System;

class Program4
{
    static void Main(string[] args)
    {
        
        Console.Write("Enter the radius of the circle: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        double area = Math.PI * Math.Pow(radius, 2);

        Console.WriteLine("The area of a circle with radius is .", radius, area);
    }
}

using System;

class Program2
{
    static void Main(string[] args)
    {
        Console.Write("Enter the length of the rectangle: ");
        int length = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the width of the rectangle: ");
        int width = Convert.ToInt32(Console.ReadLine());

        int perimeter = 2 * (length + width);

        Console.WriteLine("The perimeter of a rectangle with length {0} and width {1} is {2}.", length, width, perimeter);
    }
}

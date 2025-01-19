using System;

class Program4
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the third number: ");
        int num3 = Convert.ToInt32(Console.ReadLine());

        double average = (num1 + num2 + num3) / 3.0;

        Console.WriteLine("The average of {0}, {1}, and {2} is {3:F2}.", num1, num2, num3, average);
    }
}

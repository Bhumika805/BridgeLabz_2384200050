using System;

class Program3
{
    static void Main(string[] args)
    {
        Console.Write("Enter the base: ");
        int baseNum = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the exponent: ");
        int exponent = Convert.ToInt32(Console.ReadLine());

        double result = Math.Pow(baseNum, exponent);

        Console.WriteLine("{0} raised to the power of {1} is {2}.", baseNum, exponent, result);
    }
}

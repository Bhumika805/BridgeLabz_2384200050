using System;

class Program1
{
    static void Main(string[] args)
    {
        
        Console.Write("Enter the Principal amount: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the Rate of interest (%): ");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the Time period (in years): ");
        double time = Convert.ToDouble(Console.ReadLine());

        double simpleInterest = (principal * rate * time) / 100;

        Console.WriteLine("The Simple Interest for a principal amount of {0}, rate {1}%, and time {2} years is {3:F2}.", principal, rate, time, simpleInterest);
    }
}

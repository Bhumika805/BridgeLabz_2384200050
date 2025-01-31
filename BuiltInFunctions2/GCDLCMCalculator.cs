using System;

namespace BuiltInFunctions2
{
    public class GCDLCMCalculator
    {
        public void InputMethod()
        {
            Console.WriteLine("Enter two numbers:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            int gcd = CalculateGCD(a, b);
            int lcm = (a * b) / gcd;

            Console.WriteLine($"GCD: {gcd}, LCM: {lcm}");
        }

        private int CalculateGCD(int a, int b)
        {
            return (b == 0) ? a : CalculateGCD(b, a % b);
        }
    }
}

using System;

namespace BuiltInFunctions2
{
    public class MaximumOfThree
    {
        public void InputMethod()
        {
            Console.WriteLine("Enter three numbers:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            int max = FindMaximum(a, b, c);
            DisplayResult(max);
        }

        private int FindMaximum(int a, int b, int c)
        {
            return Math.Max(a, Math.Max(b, c));
        }

        private void DisplayResult(int max)
        {
            Console.WriteLine($"The maximum number is: {max}");
        }
    }
}

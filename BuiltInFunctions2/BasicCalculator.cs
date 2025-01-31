using System;

namespace BuiltInFunctions2
{
    public class BasicCalculator
    {
        public void InputMethod()
        {
            Console.WriteLine("Enter two numbers:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose operation (+, -, *, /):");
            char op = Console.ReadKey().KeyChar;
            Console.WriteLine();

            double result = Calculate(num1, num2, op);
            Console.WriteLine($"Result: {result}");
        }

        private double Calculate(double a, double b, char op) =>
            op switch { '+' => a + b,
						'-' => a - b, 
						'*' => a * b,
						'/' => a / b,
						  _ => 0 };
    }
}

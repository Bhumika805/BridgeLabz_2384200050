using System;

namespace ControlFlowLevel3
{
    class Calculator
    {
        public void CalcOperation()
        {
            Console.Write("Enter the first number: ");
            string firstInput = Console.ReadLine();

            Console.Write("Enter the second number: ");
            string secondInput = Console.ReadLine();

            Console.Write("Enter the operator (+, -, *, /): ");
            string op = Console.ReadLine();

            // Declare variables to store the numbers
            double first, second;

            // Validate input: Attempt to convert input strings to doubles
            if (!double.TryParse(firstInput, out first) || !double.TryParse(secondInput, out second))
            {
                Console.WriteLine("Invalid input for numbers.");
                return; // Exit the method if input is invalid
            }

            // Initialize result variable
            double result = 0.0;

            // Use a switch statement to determine the operation
            switch (op)
            {
                case "+": // Addition
                    result = first + second;
                    break;
                case "-": // Subtraction
                    result = first - second;
                    break;
                case "*": // Multiplication
                    result = first * second;
                    break;
                case "/": // Division
                    if (second == 0) 
                    {
                        Console.WriteLine("Error: Division by zero");
                    }
                    else
                    {
                        result = first / second;
                    }
                    break;
                default: // Handle invalid operator
                    Console.WriteLine("Invalid Operator");
                    break;
            }

            // Display the calculated result
            Console.WriteLine("Result: " + result);
        }
    }
}
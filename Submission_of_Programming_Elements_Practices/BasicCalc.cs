using System;

namespace Submission_of_Programming_Elements_Practices
{
    // Class to perform basic arithmetic operations
    class BasicCalc
    {
        public void PerformOperation()
        {
            // Prompt the user to enter the first number
            Console.Write("Enter the first number: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            // Prompt the user to enter the second number
            Console.Write("Enter the second number: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            // Perform basic arithmetic operations
            double addition = number1 + number2;
            double subtraction = number1 - number2;
            double multiplication = number1 * number2;

            // Handle division, checking for division by zero
            double division = number2 != 0 ? number1 / number2 : double.NaN;

            // Display the results of all operations
            Console.WriteLine($"The addition, subtraction, multiplication, and division value of numbers {number1} and {number2} is: " +
                              $"Addition: {addition:F2}, Subtraction: {subtraction:F2}, Multiplication: {multiplication:F2}, " +
                              $"Division: {(number2 != 0 ? $"{division:F2}" : "undefined (division by zero)")} ");
        }
    }
}

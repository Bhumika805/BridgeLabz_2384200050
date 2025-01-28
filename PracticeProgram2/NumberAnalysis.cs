using System;

namespace PracticeProblem2
{
    public class NumberChecker
    {
        public bool IsPositive(int number)
        {
            return number >= 0;
        }

        public bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public int Compare(int number1, int number2)
        {
            if (number1 > number2)
                return 1;
            else if (number1 < number2)
                return -1;
            else
                return 0;
        }
    }

    class NumberAnalysis
    {
        public void Analysation()
        {
            NumberChecker checker = new NumberChecker(); // Corrected capitalization
            int[] numbers = new int[5];

            Console.WriteLine("Enter 5 numbers: ");

            for (int i = 0; i < numbers.Length; i++) // Fixed typo in "numbers.Length"
            {
                Console.Write($"Enter number {i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine()); // Properly reading numbers

                if (checker.IsPositive(numbers[i]))
                {
                    Console.WriteLine($"Number {numbers[i]} is Positive.");
                    if (checker.IsEven(numbers[i]))
                    {
                        Console.WriteLine($"Number {numbers[i]} is Even.");
                    }
                    else
                    {
                        Console.WriteLine($"Number {numbers[i]} is Odd."); // Fixed typo in variable name
                    }
                }
                else
                {
                    Console.WriteLine($"Number {numbers[i]} is Negative."); // Fixed typo in variable name
                }
            }

            // Comparing the first and last numbers
            int result = checker.Compare(numbers[0], numbers[numbers.Length - 1]);

            Console.WriteLine("\nComparison of the first and last elements:");
            if (result == 1)
            {
                Console.WriteLine("The first number is greater than the last number.");
            }
            else if (result == -1)
            {
                Console.WriteLine("The first number is less than the last number.");
            }
            else
            {
                Console.WriteLine("The first number is equal to the last number.");
            }
        }
    }
}

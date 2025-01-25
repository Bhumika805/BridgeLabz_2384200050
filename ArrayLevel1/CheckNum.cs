using System;

namespace ArrayLevel1
{
    class CheckNum
    {
        public void NumberCheck()
        {
            int[] numbers = new int[5];

            // Get user input for the array
            Console.WriteLine("Enter 5 numbers:");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Number " + (i + 1) + ": ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Loop through the array to check if each number is positive, negative, or zero
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0) // Positive number
                {
                    if (numbers[i] % 2 == 0)
                        Console.WriteLine(numbers[i] + " is positive and even.");
                    else
                        Console.WriteLine(numbers[i] + " is positive and odd.");
                }
                else if (numbers[i] < 0) // Negative number
                {
                    Console.WriteLine(numbers[i] + " is negative.");
                }
                else // Zero
                {
                    Console.WriteLine(numbers[i] + " is zero.");
                }
            }

            // Compare the first and last elements of the array
            if (numbers[0] == numbers[4])
            {
                Console.WriteLine("The first and last elements are equal.");
            }
            else if (numbers[0] > numbers[4])
            {
                Console.WriteLine("The first element is greater than the last element.");
            }
            else
            {
                Console.WriteLine("The first element is less than the last element.");
            }
        }
    }
}

using System;

namespace PracticeProblem1
{
    class SmallestAndLargest
    {
        public void Smallest__Largest()
        {
            Console.Write("Enter the first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the third number: ");
            int number3 = Convert.ToInt32(Console.ReadLine());

            // Call the method to find the smallest and largest numbers
            int[] result = FindSmallestAndLargest(number1, number2, number3);

            // Output the smallest and largest numbers
            Console.WriteLine($"\nThe smallest number is: {result[0]}");
            Console.WriteLine($"The largest number is: {result[1]}");
        }

        // Method to find the smallest and largest of three numbers
        public static int[] FindSmallestAndLargest(int number1, int number2, int number3)
        {
            int smallest = Math.Min(number1, Math.Min(number2, number3)); // Find the smallest
            int largest = Math.Max(number1, Math.Max(number2, number3));  // Find the largest

            return new int[] { smallest, largest }; // Return the results as an array
        }
    }
}

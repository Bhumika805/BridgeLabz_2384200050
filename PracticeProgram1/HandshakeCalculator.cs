using System;

namespace PracticeProblem1
{
    class HandshakeCalculator
    {
        public void CalculateAndDisplayHandshakes()
        {
            Console.Write("Enter the number of students: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Validate input
            if (n < 2)
            {
                Console.WriteLine("Number of students must be 2 or more to have handshakes.");
                return;
            }

            // Call the method to calculate the maximum number of handshakes
            int maxHandshakes = CalculateHandshakes(n);

            // Display the result
            Console.WriteLine($"The maximum number of handshakes among {n} students is {maxHandshakes}.");
        }

        // Method to calculate the maximum number of handshakes using the formula
        public int CalculateHandshakes(int n)
        {
            return (n * (n - 1)) / 2;
        }
    }
}

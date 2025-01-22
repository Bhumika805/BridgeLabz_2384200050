using System;

namespace Submission_of_Programming_Elements_Practices
{
    // Class to calculate the maximum number of handshakes among a given number of students
    class HandshakeCalculator
    {
        public void CalculateHandshakes()
        {
            // Prompt the user to enter the number of students
            Console.Write("Enter the number of students: ");
            int numberOfStudents = Convert.ToInt32(Console.ReadLine());

            // Calculate the maximum number of handshakes using the formula: n * (n - 1) / 2
            int maxHandshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;

            // Display the result
            Console.WriteLine($"The maximum number of handshakes among {numberOfStudents} students is {maxHandshakes}.");
        }
    }
}

using System;

namespace PracticeProblem1
{
    class HandshakeProgram
    {
        public void DisplayHandshakes()
        {
            Console.Write("Enter the number of students: ");
            int numberOfStudents = Convert.ToInt32(Console.ReadLine());

            // Validate input
            if (numberOfStudents < 2)
            {
                Console.WriteLine("Number of students must be 2 or more to have handshakes.");
            }
            else
            {
                // Calculate the maximum number of handshakes
                int maxHandshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;

                // Display the result
                Console.WriteLine($"The maximum number of handshakes among {numberOfStudents} students is {maxHandshakes}.");
            }
        }
    }
}

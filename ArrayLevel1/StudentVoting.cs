using System;

namespace ArrayLevel1
{
class StudentVoting
{
    public void AgeOfStudent()
    {
        // Array to store the ages of 10 students
        int[] studentAges = new int[10];

        Console.WriteLine("Enter the ages of 10 students:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Enter age for student {i + 1}: ");
			
			int age = Convert.ToInt32(Console.ReadLine());

            if (age < 0)
            {
                Console.WriteLine("Invalid age. Please enter a non-negative number.");
                i--; // Repeat the input for the same student
            }
            else
            {
                studentAges[i] = age; // Store the valid age
            }
        }

        Console.WriteLine("\nVoting eligibility results:");

        for (int i = 0; i < studentAges.Length; i++)
        {
            if (studentAges[i] >= 18)
            {
                Console.WriteLine($"The student with the age {studentAges[i]} can vote.");
            }
            else
            {
                Console.WriteLine($"The student with the age {studentAges[i]} cannot vote.");
            }
        }
    }
}
}

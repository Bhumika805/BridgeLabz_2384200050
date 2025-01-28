using System;

namespace PracticeProblem2
{
    public class StudentVoteChecker
    {
        // Method to check if the student can vote based on their age
        public bool CanStudentVote(int age)
        {
            // Validate age for a negative number
            if (age < 0)
            {
                return false; // Cannot vote if the age is negative
            }

            // Check if the age is 18 or above
            return age >= 18;
        }
    }

    class StudentVote__Checker 
    {
        public void StudentVote()
        {
            StudentVoteChecker voteChecker = new StudentVoteChecker();

            // Array to store ages of 10 students
            int[] ages = new int[10];

            // Loop to take user input for each student's age
            for (int i = 0; i < ages.Length; i++)
            {
                Console.Write($"Enter age of student {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int age)) // Validate user input
                {
                    ages[i] = age;

                    // Check if the student can vote and display the result
                    bool canVote = voteChecker.CanStudentVote(age);
                    if (canVote)
                    {
                        Console.WriteLine($"Student {i + 1} can vote.");
                    }
                    else
                    {
                        Console.WriteLine($"Student {i + 1} cannot vote.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid age.");
                    i--; // Decrement to repeat the current iteration
                }
            }
        }
    }
}

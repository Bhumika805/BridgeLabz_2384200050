using System;

namespace PracticeProblem3
{
    class StudentScoreCard
    {
        // Method to generate random 2-digit scores for Physics, Chemistry, and Math for the students
        public static double[,] GenerateRandomScores(int numStudents)
        {
            Random rand = new Random();
            double[,] scores = new double[numStudents, 3]; // 2D array to store PCM scores

            for (int i = 0; i < numStudents; i++)
            {
                scores[i, 0] = rand.Next(10, 100); // Random Physics score between 10 and 99
                scores[i, 1] = rand.Next(10, 100); // Random Chemistry score between 10 and 99
                scores[i, 2] = rand.Next(10, 100); // Random Math score between 10 and 99
            }

            return scores;
        }

        // Method to calculate the total, average, and percentage for each student
        public static double[,] CalculateResults(double[,] scores, int numStudents)
        {
            double[,] results = new double[numStudents, 4]; // 2D array to store Total, Average, Percentage

            for (int i = 0; i < numStudents; i++)
            {
                double total = scores[i, 0] + scores[i, 1] + scores[i, 2];
                double average = total / 3;
                double percentage = (total / 300) * 100;

                // Round the results to 2 decimal places
                results[i, 0] = Math.Round(total, 2);
                results[i, 1] = Math.Round(average, 2);
                results[i, 2] = Math.Round(percentage, 2);
            }

            return results;
        }

        // Method to display the scorecard in a tabular format
        public static void DisplayScoreCard(double[,] scores, double[,] results, int numStudents)
        {
            Console.WriteLine("Student Scorecard");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Student | Physics | Chemistry | Math | Total | Average | Percentage");

            for (int i = 0; i < numStudents; i++)
            {
                Console.WriteLine($"{i + 1,-8}| {scores[i, 0],-8} | {scores[i, 1],-9} | {scores[i, 2],-5} | {results[i, 0],-5} | {results[i, 1],-7} | {results[i, 2],-10}");
            }

            Console.WriteLine("------------------------------------------------------------");
        }

		public void InputMethod()
        {
            Console.Write("Enter the number of students: ");
            int numStudents = Convert.ToInt32(Console.ReadLine());

            // Step 1: Generate random scores for Physics, Chemistry, and Math
            double[,] scores = GenerateRandomScores(numStudents);

            // Step 2: Calculate total, average, and percentage
            double[,] results = CalculateResults(scores, numStudents);

            // Step 3: Display the scorecard in a tabular format
            DisplayScoreCard(scores, results, numStudents);
        }
    }
}

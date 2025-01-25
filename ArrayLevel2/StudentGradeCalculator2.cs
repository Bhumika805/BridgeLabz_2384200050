using System;

namespace ArrayLevel2
{
    class StudentGradeCalculator2
    {
        public void GradeCalculator2()
        {
            // Input number of students
            Console.Write("Enter the number of students: ");
            int numberOfStudents = Convert.ToInt32(Console.ReadLine());

            // Create a 2D array to store marks (3 subjects for each student)
            double[,] marks = new double[numberOfStudents, 3];
            double[] percentages = new double[numberOfStudents];
            string[] grades = new string[numberOfStudents];
            string[] remarks = new string[numberOfStudents];
            string[] marksRange = new string[numberOfStudents];

            // Loop to take input for each student's marks
            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.WriteLine($"\nEnter marks for student {i + 1}:");

                // Input physics marks
                do
                {
                    Console.Write("Physics marks (0-100): ");
                    marks[i, 0] = Convert.ToDouble(Console.ReadLine());
                    if (marks[i, 0] < 0 || marks[i, 0] > 100)
                    {
                        Console.WriteLine("Invalid input. Marks should be between 0 and 100.");
                    }
                } while (marks[i, 0] < 0 || marks[i, 0] > 100);

                // Input chemistry marks
                do
                {
                    Console.Write("Chemistry marks (0-100): ");
                    marks[i, 1] = Convert.ToDouble(Console.ReadLine());
                    if (marks[i, 1] < 0 || marks[i, 1] > 100)
                    {
                        Console.WriteLine("Invalid input. Marks should be between 0 and 100.");
                    }
                } while (marks[i, 1] < 0 || marks[i, 1] > 100);

                // Input maths marks
                do
                {
                    Console.Write("Maths marks (0-100): ");
                    marks[i, 2] = Convert.ToDouble(Console.ReadLine());
                    if (marks[i, 2] < 0 || marks[i, 2] > 100)
                    {
                        Console.WriteLine("Invalid input. Marks should be between 0 and 100.");
                    }
                } while (marks[i, 2] < 0 || marks[i, 2] > 100);

                // Calculate percentage
                double totalMarks = marks[i, 0] + marks[i, 1] + marks[i, 2];
                percentages[i] = (totalMarks / 300) * 100;

                // Calculate grade and remarks based on percentage
                if (percentages[i] >= 80)
                {
                    grades[i] = "A";
                    remarks[i] = "Level 4, above agency-normalized standards";
                    marksRange[i] = "80% and above";
                }
                else if (percentages[i] >= 70)
                {
                    grades[i] = "B";
                    remarks[i] = "Level 3, at agency-normalized standards";
                    marksRange[i] = "70-79%";
                }
                else if (percentages[i] >= 60)
                {
                    grades[i] = "C";
                    remarks[i] = "Level 2, below, but approaching agency-normalized standards";
                    marksRange[i] = "60-69%";
                }
                else if (percentages[i] >= 50)
                {
                    grades[i] = "D";
                    remarks[i] = "Level 1, well below agency-normalized standards";
                    marksRange[i] = "50-59%";
                }
                else if (percentages[i] >= 40)
                {
                    grades[i] = "E";
                    remarks[i] = "Level 1-, too below agency-normalized standards";
                    marksRange[i] = "40-49%";
                }
                else
                {
                    grades[i] = "R";
                    remarks[i] = "Remedial standards";
                    marksRange[i] = "39% and below";
                }
            }

            // Display the results
            Console.WriteLine("\nStudent Report:");
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.WriteLine("Student | Physics | Chemistry | Maths | Percentage | Grade | Remarks                                       | Marks Range");
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.WriteLine($"{i + 1,7} | {marks[i, 0],7} | {marks[i, 1],9} | {marks[i, 2],5} | {percentages[i],10:F2} | {grades[i],5} | {remarks[i],45} | {marksRange[i],13}");
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
        }
    }
}

using System;

namespace ArrayLevel2
{
    class StudentGradeCalculator
    {
        public void GradeCalculator()
        {
           Console.Write("Enter the number of students: ");
            int numberOfStudents = Convert.ToInt32(Console.ReadLine());

            // Create arrays to store marks, percentages, and grades of students
            double[] physicsMarks = new double[numberOfStudents];
            double[] chemistryMarks = new double[numberOfStudents];
            double[] mathsMarks = new double[numberOfStudents];
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
                    physicsMarks[i] = Convert.ToDouble(Console.ReadLine());
                    if (physicsMarks[i] < 0 || physicsMarks[i] > 100)
                    {
                        Console.WriteLine("Invalid input. Marks should be between 0 and 100.");
                    }
                } while (physicsMarks[i] < 0 || physicsMarks[i] > 100);

                // Input chemistry marks
                do
                {
                    Console.Write("Chemistry marks (0-100): ");
                    chemistryMarks[i] = Convert.ToDouble(Console.ReadLine());
                    if (chemistryMarks[i] < 0 || chemistryMarks[i] > 100)
                    {
                        Console.WriteLine("Invalid input. Marks should be between 0 and 100.");
                    }
                } while (chemistryMarks[i] < 0 || chemistryMarks[i] > 100);

                // Input maths marks
                do
                {
                    Console.Write("Maths marks (0-100): ");
                    mathsMarks[i] = Convert.ToDouble(Console.ReadLine());
                    if (mathsMarks[i] < 0 || mathsMarks[i] > 100)
                    {
                        Console.WriteLine("Invalid input. Marks should be between 0 and 100.");
                    }
                } while (mathsMarks[i] < 0 || mathsMarks[i] > 100);

                // Calculate percentage
                double totalMarks = physicsMarks[i] + chemistryMarks[i] + mathsMarks[i];
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
                Console.WriteLine($"{i + 1,7} | {physicsMarks[i],7} | {chemistryMarks[i],9} | {mathsMarks[i],5} | {percentages[i],10:F2} | {grades[i],5} | {remarks[i],45} | {marksRange[i],13}");
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
        }
    }
}
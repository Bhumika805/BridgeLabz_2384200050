using System;

namespace ControlFlowLevel2
{
    class GradeCalculator
    {
        public void Grading()
        {
            // Input marks for three subjects
            Console.WriteLine("Enter marks for Physics: ");
            double physics = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter marks for Chemistry: ");
            double chemistry = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter marks for Maths: ");
            double maths = Convert.ToDouble(Console.ReadLine());

            // Compute total and average marks
            double totalMarks = physics + chemistry + maths;
            double percentage = (totalMarks / 300) * 100; // Assuming each subject is out of 100
            string grade = "";
            string remarks = "";

            // Determine grade and remarks based on percentage
            if (percentage >= 80)
            {
                grade = "A";
                remarks = "Level 4, above agency-normalized standards";
            }
            else if (percentage >= 70)
            {
                grade = "B";
                remarks = "Level 3, at agency-normalized standards";
            }
            else if (percentage >= 60)
            {
                grade = "C";
                remarks = "Level 2, below but approaching agency-normalized standards";
            }
            else if (percentage >= 50)
            {
                grade = "D";
                remarks = "Level 1, well below agency-normalized standards";
            }
            else if (percentage >= 40)
            {
                grade = "E";
                remarks = "Level 1-, too below agency-normalized standards";
            }
            else
            {
                grade = "R";
                remarks = "Remedial standards";
            }

            // Output the results
            Console.WriteLine("\n--- Result ---");
            Console.WriteLine($"Average Marks: {percentage:F2}%");
            Console.WriteLine($"Grade: {grade}");
            Console.WriteLine($"Remarks: {remarks}");
        }
    }
}

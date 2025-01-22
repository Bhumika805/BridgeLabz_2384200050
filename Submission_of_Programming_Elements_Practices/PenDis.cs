using System;

namespace Submission_of_Programming_Elements_Practices
{
    // Class to calculate the distribution of pens among students
    class PenDis
    {
        public void Distribution()
        {
            // Define the total number of pens and students
            int pen = 14;
            int totalstudents  = 3;

            // Calculate how many pens each student gets and the remaining pens
            int penPerStu = pen / totalstudents ; // Division for pens per student
            int rem = pen % totalstudents ;       // Remainder for pens not distributed

            // Display the result
            Console.WriteLine($"The Pen Per Student is {penPerStu} and the remaining pen not distributed is {rem}");
        }
    }
}

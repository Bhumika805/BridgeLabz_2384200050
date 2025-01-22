using System;

namespace Submission_of_Programming_Elements_Practices
{
    // Class to calculate Harry's age based on birth year and current year
    class CalculateAge
    {
        public void AgeCalculate()
        {
            // Define Harry's birth year and the current year
            int bornYear = 2000;
            int currentYear = 2024;

            // Calculate the age by subtracting the birth year from the current year
            int result = currentYear - bornYear;

            // Display Harry's age in 2024
            Console.WriteLine($"Harry's age in 2024 is {result}");
        }
    }
}


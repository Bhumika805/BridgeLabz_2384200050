using System;

namespace PracticeProblem1
{
    class SpringSeasonChecker
    {
        public void SeasonChecker()
        {
            // Prompt user for month and day
            Console.Write("Enter the month (1-12): ");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the day (1-31): ");
            int day = Convert.ToInt32(Console.ReadLine());

            // Call the method to check if it's Spring Season
            bool isSpring = IsSpringSeason(month, day);

            // Print the result
            if (isSpring)
            {
                Console.WriteLine("It's a Spring Season.");
            }
            else
            {
                Console.WriteLine("Not a Spring Season.");
            }
        }

        // Method to check if the date falls within Spring Season
        static bool IsSpringSeason(int month, int day)
        {
            // Check if the date is within the Spring Season range
            if ((month == 3 && day >= 20 && day <= 31) ||  // March 20 - 31
                (month == 4 && day >= 1 && day <= 30) ||   // April 1 - 30
                (month == 5 && day >= 1 && day <= 31) ||   // May 1 - 31
                (month == 6 && day >= 1 && day <= 20))     // June 1 - 20
            {
                return true;
            }
            return false;
        }
    }
}

using System;

class DayOfWeek
{
    // Main function
    static void Main(string[] args)
    {
        // Check if the correct number of arguments is provided
        if (args.Length != 3)
        {
            Console.WriteLine("Enter the date in format MM DD YYYY");
            return; // Exit the program if incorrect number of arguments
        }

        // Parse command-line arguments to integers
        int m = Convert.ToInt32(args[0]); // Month
        int d = Convert.ToInt32(args[1]); // Day
        int y = Convert.ToInt32(args[2]); // Year

        // Calculate y0 (adjusted year)
        int y0 = y - (14 - m) / 12;

        // Calculate x (intermediate value)
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;

        // Calculate m0 (adjusted month)
        int m0 = m + 12 * ((14 - m) / 12) - 2;

        // Calculate d0 (day of the week)
        int d0 = (d + x + (31 * m0) / 12) % 7;

        // Print the result
        Console.WriteLine($"The day of the week for {m}/{d}/{y} is: {d0}");

        // Display a legend for day of the week values
        Console.WriteLine("Where 0.Sunday\n1.Monday\n2.Tuesday\n3.Wednesday\n4.Thursday\n5.Friday\n6.Saturday\n7.Sunday"); 
    }
}
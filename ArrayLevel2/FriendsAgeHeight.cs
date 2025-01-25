using System;

namespace ArrayLevel2
{
    class FriendsAgeHeight
    {
        public void CheckFriendsAgeHeight()
        {
            int[] ages = new int[3];
            double[] heights = new double[3];

            // Get the input for age and height from the user
            Console.WriteLine("Enter the age and height for the following friends:");
            
            // Input data for Amar
            Console.Write("Amar's age: ");
            ages[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Amar's height (in meters): ");
            heights[0] = Convert.ToDouble(Console.ReadLine());

            // Input data for Akbar
            Console.Write("Akbar's age: ");
            ages[1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Akbar's height (in meters): ");
            heights[1] = Convert.ToDouble(Console.ReadLine());

            // Input data for Anthony
            Console.Write("Anthony's age: ");
            ages[2] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Anthony's height (in meters): ");
            heights[2] = Convert.ToDouble(Console.ReadLine());

            // Initialize variables to store the youngest and tallest friend
            int youngestAge = ages[0];
            int youngestIndex = 0;
            double tallestHeight = heights[0];
            int tallestIndex = 0;

            // Loop through the arrays to find the youngest and tallest
            for (int i = 1; i < 3; i++)
            {
                // Check for the youngest friend
                if (ages[i] < youngestAge)
                {
                    youngestAge = ages[i];
                    youngestIndex = i;
                }

                // Check for the tallest friend
                if (heights[i] > tallestHeight)
                {
                    tallestHeight = heights[i];
                    tallestIndex = i;
                }
            }

            // Output the youngest and tallest friend
            string[] names = { "Amar", "Akbar", "Anthony" };
            Console.WriteLine($"\nThe youngest friend is {names[youngestIndex]} with age {youngestAge}.");
            Console.WriteLine($"The tallest friend is {names[tallestIndex]} with height {tallestHeight} meters.");
        }
    }
}

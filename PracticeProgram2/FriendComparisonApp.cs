using System;

namespace PracticeProblem2
{
    public class FriendComparison
    {
        // Method to find the youngest of the 3 friends
        public string FindYoungest(int[] ages)
        {
            int minAge = ages[0];
            string youngestFriend = "Amar"; // Assume Amar is the youngest initially

            for (int i = 1; i < ages.Length; i++)
            {
                if (ages[i] < minAge)
                {
                    minAge = ages[i];
                    if (i == 1)
                        youngestFriend = "Akbar";
                    else if (i == 2)
                        youngestFriend = "Anthony";
                }
            }

            return youngestFriend;
        }

        // Method to find the tallest of the 3 friends
        public string FindTallest(double[] heights)
        {
            double maxHeight = heights[0];
            string tallestFriend = "Amar"; // Assume Amar is the tallest initially

            for (int i = 1; i < heights.Length; i++)
            {
                if (heights[i] > maxHeight)
                {
                    maxHeight = heights[i];
                    if (i == 1)
                        tallestFriend = "Akbar";
                    else if (i == 2)
                        tallestFriend = "Anthony";
                }
            }

            return tallestFriend;
        }
    }

    class FriendComparisonApp
    {
        public void ComparisonApp()
        {
            FriendComparison comparison = new FriendComparison();

            // Arrays to store the ages and heights of the friends
            int[] ages = new int[3];
            double[] heights = new double[3];

            // Taking user input for ages
            Console.Write("Enter the age of Amar: ");
            ages[0] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the age of Akbar: ");
            ages[1] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the age of Anthony: ");
            ages[2] = Convert.ToInt32(Console.ReadLine());

            // Taking user input for heights
            Console.Write("Enter the height of Amar (in meters): ");
            heights[0] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the height of Akbar (in meters): ");
            heights[1] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the height of Anthony (in meters): ");
            heights[2] = Convert.ToDouble(Console.ReadLine());

            // Finding the youngest and tallest friends
            string youngest = comparison.FindYoungest(ages);
            string tallest = comparison.FindTallest(heights);

            // Displaying the results
            Console.WriteLine($"\nThe youngest friend is: {youngest}");
            Console.WriteLine($"The tallest friend is: {tallest}");
        }
    }
}

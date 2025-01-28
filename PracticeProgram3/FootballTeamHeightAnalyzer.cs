using System;

namespace PracticeProblem3
{
    public class FootballTeamHeightAnalyzer
    {
        // Method to generate random heights for players
        public static int[] GenerateRandomHeights(int size)
        {
            Random random = new Random();
            int[] heights = new int[size];

            for (int i = 0; i < size; i++)
            {
                heights[i] = random.Next(150, 251); // Generate random height between 150 and 250 cm
            }

            return heights;
        }

        // Method to calculate the sum of all heights
        public static int FindSum(int[] heights)
        {
            int sum = 0;
            foreach (int height in heights)
            {
                sum += height;
            }
            return sum;
        }

        // Method to calculate the mean height
        public static double FindMean(int[] heights)
        {
            int sum = FindSum(heights);
            return (double)sum / heights.Length;
        }

        // Method to find the shortest height
        public static int FindShortest(int[] heights)
        {
            int shortest = heights[0];
            foreach (int height in heights)
            {
                shortest = Math.Min(shortest, height);
            }
            return shortest;
        }

        // Method to find the tallest height
        public static int FindTallest(int[] heights)
        {
            int tallest = heights[0];
            foreach (int height in heights)
            {
                tallest = Math.Max(tallest, height);
            }
            return tallest;
        }

        // Input and display the results
        public static void AnalyzeHeights()
        {
            const int teamSize = 11; // Size of the football team
            int[] heights = GenerateRandomHeights(teamSize);

            Console.WriteLine("Player Heights (in cm):");
            foreach (int height in heights)
            {
                Console.WriteLine(height);
            }

            int shortest = FindShortest(heights);
            int tallest = FindTallest(heights);
            double mean = FindMean(heights);

            Console.WriteLine($"\nResults:");
            Console.WriteLine($"Shortest Height: {shortest} cm");
            Console.WriteLine($"Tallest Height: {tallest} cm");
            Console.WriteLine($"Mean Height: {mean:F2} cm");
        }
    }
}

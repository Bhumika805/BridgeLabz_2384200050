using System;

namespace ArrayLevel1
{
    class FootballTeam
    {
        public void Team_Football()
        {
            // Create a double array named heights of size 11 to store the heights of the players
            double[] heights = new double[11];
            double sum = 0.0;  // Variable to store the sum of all heights

            // Prompt the user to enter the heights of 11 football players
            Console.WriteLine("Enter the heights of 11 football players:");

            // Loop through each player and get their height input
            for (int i = 0; i < heights.Length; i++)
            {
                // Ask the user to input the height for the current player
                Console.Write("Player " + (i + 1) + " height: ");
                
                // Convert the input to double and store it in the heights array
                heights[i] = Convert.ToDouble(Console.ReadLine());
                
                // Add the current player's height to the sum
                sum += heights[i]; 
            }

            // Calculate the mean height by dividing the sum by the number of players (11)
            double meanHeight = sum / heights.Length;

            // Display the calculated mean height of the football team
            Console.WriteLine("\nThe mean height of the football team is: " + meanHeight);
        }
    }
}

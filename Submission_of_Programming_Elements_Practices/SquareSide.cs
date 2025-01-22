using System;

namespace Submission_of_Programming_Elements_Practices
{
    // Class to calculate the side of a square based on its perimeter
    class SquareSide
    {
        public void CalcSide()
        {
            // Prompt the user to enter the perimeter of the square
            Console.Write("Enter the perimeter of square: ");
            int perimeter = Convert.ToInt32(Console.ReadLine());

            // Calculate the side length by dividing the perimeter by 4
            int side = perimeter / 4;

            // Display the calculated side length and given perimeter
            Console.WriteLine($"The length of the side is {side} whose perimeter is {perimeter}");
        }
    }
}

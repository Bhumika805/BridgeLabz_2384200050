using System;

namespace Assignment_2
{
    class Athlete_Rounds
    {
        public void Calculate_Rounds()
        {
            Console.Write("Enter the first side of the triangular park (in meters): ");
            double side1 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter the second side of the triangular park (in meters): ");
            double side2 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter the third side of the triangular park (in meters): ");
            double side3 = Convert.ToDouble(Console.ReadLine());
            
            double perimeter = side1 + side2 + side3; // Calculate perimeter
            double distance = 5000; // Total distance in meters (5 km)
            double rounds = Math.Ceiling(distance / perimeter); // Calculate and round up the number of rounds
            
            Console.WriteLine($"The total number of rounds the athlete will run is {rounds} to complete 5 km.");
        }
    }
}

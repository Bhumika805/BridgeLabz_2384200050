using System;

namespace ControlFlowLevel2
{
    class GreatestFactor
    {
        public void Greatest_Factor()
        {
            // Input: Take ages and heights of 3 friends
            Console.WriteLine("Enter the age of Amar: ");
            int ageAmar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the height of Amar: ");
            double heightAmar = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the age of Akbar: ");
            int ageAkbar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the height of Akbar: ");
            double heightAkbar = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the age of Anthony: ");
            int ageAnthony = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the height of Anthony: ");
            double heightAnthony = Convert.ToDouble(Console.ReadLine());

            // Find the youngest friend
            int youngestAge = Math.Min(ageAmar, Math.Min(ageAkbar, ageAnthony));
            string youngestFriend = "";
            if (youngestAge == ageAmar) youngestFriend = "Amar";
            else if (youngestAge == ageAkbar) youngestFriend = "Akbar";
            else youngestFriend = "Anthony";

            // Find the tallest friend
            double tallestHeight = Math.Max(heightAmar, Math.Max(heightAkbar, heightAnthony));
            string tallestFriend = "";
            if (tallestHeight == heightAmar) tallestFriend = "Amar";
            else if (tallestHeight == heightAkbar) tallestFriend = "Akbar";
            else tallestFriend = "Anthony";

            // Output results
            Console.WriteLine($"The youngest friend is {youngestFriend} with age {youngestAge}.");
            Console.WriteLine($"The tallest friend is {tallestFriend} with height {tallestHeight} cm.");
        }
    }
}

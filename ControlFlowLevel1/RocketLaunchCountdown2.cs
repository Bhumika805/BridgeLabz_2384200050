using System;

namespace ControlFlowLevel1
{
    class RocketLaunchCountdown2
    {
        public void RocketLaunch2()
        {
            Console.Write("Enter the countdown start value: ");
            int counter = Convert.ToInt32(Console.ReadLine());

            // Check if the input is valid (greater than or equal to 1)
            if (counter < 1)
            {
                Console.WriteLine("Please enter a number greater than or equal to 1.");
                return;
            }

            Console.WriteLine("\nCountdown begins:");

            // Countdown using a for loop
            for (int i = counter; i >= 1; i--)
            {
                Console.WriteLine(i);
            }

            // Print the final message after the countdown
            Console.WriteLine("Blast off!");
        }
    }
}

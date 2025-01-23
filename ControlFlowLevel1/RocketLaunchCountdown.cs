using System;

namespace ControlFlowLevel1
{
    class RocketLaunchCountdown
    {
        public void RocketLaunch()
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

            // Countdown using a while loop
            while (counter >= 1)
            {
                Console.WriteLine(counter);
                counter--; // Decrement the counter
            }

            // Print the final message after the countdown
            Console.WriteLine("Blast off!");
        }
    }
}

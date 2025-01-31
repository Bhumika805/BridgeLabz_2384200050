using System;

namespace BuiltInFunctions2
{
    public class NumberGuessingGame
    {
        private int min = 1, max = 100;
        private Random random = new Random();

        public void StartGame()
        {
            Console.WriteLine("Think of a number between 1 and 100. I will try to guess it!");
            PlayGame();
        }

        private void PlayGame()
        {
            while (true)
            {
                int guess = random.Next(min, max + 1);
                Console.WriteLine($"Is your number {guess}? (Enter 'H' for too high, 'L' for too low, 'C' for correct)");
                char feedback = Char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();

                if (feedback == 'C')
                {
                    Console.WriteLine("Yay! I guessed your number.");
                    break;
                }
                else if (feedback == 'H')
                {
                    max = guess - 1;
                }
                else if (feedback == 'L')
                {
                    min = guess + 1;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter H, L, or C.");
                }
            }
        }
    }
}

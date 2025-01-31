using System;

namespace BuiltInFunctions2
{
    public class PrimeNumberChecker
    {
        public void InputMethod()
        {
            Console.WriteLine("Enter a number to check if it's prime:");
            int num = Convert.ToInt32(Console.ReadLine());

            bool isPrime = CheckPrime(num);
            DisplayResult(num, isPrime);
        }

        private bool CheckPrime(int num)
        {
            if (num < 2) return false;
            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }

        private void DisplayResult(int num, bool isPrime)
        {
            Console.WriteLine(isPrime ? $"{num} is a prime number." : $"{num} is not a prime number.");
        }
    }
}

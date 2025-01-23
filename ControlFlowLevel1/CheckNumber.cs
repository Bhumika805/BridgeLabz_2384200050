using System;

namespace ControlFlowLevel1
{
    class CheckNumber
    {
        public void num()
        {
            Console.Write("Enter a number: ");
            
            // Read user input and convert it to an integer
            int a = Convert.ToInt32(Console.ReadLine());
            
            // Check if the number is divisible by 5 using the modulus operator
            if (a % 5 == 0) 
            {
                // If divisible, print the appropriate message
                Console.WriteLine($" Is the number {a} divisible by 5? Yes");
            }
            else
            {
                // If not divisible, print the appropriate message
                Console.WriteLine($"Is the number {a} divisible by 5 ? No");
            }
        }
    }
}

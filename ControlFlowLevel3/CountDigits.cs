using System;

namespace ControlFlowLevel3
{
    class CountDigits
    {
        public void CountDigitsInNumber()
        {
            Console.Write("Enter a number to count its digits: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Initialize count to 0
            int count = 0;

            // Handle case for zero
            if (number == 0)
            {
                count = 1;
            }

            // Use a while loop to count digits
            while (number != 0)
            {
                // Remove the last digit by dividing the number by 10
                number /= 10;

                // Increment the count by 1
                count++;
            }

            // Output the count of digits
            Console.WriteLine("The number of digits is: " + count);
        }
    }
}

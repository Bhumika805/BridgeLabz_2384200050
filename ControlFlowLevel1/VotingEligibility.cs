using System;

namespace ControlFlowLevel1
{
    class VotingEligibility
    {
        public void CheckVotingEligibility()
        {
            Console.WriteLine("Enter the age of the person:");
            int age = Convert.ToInt32(Console.ReadLine());

            // Check if the person's age is 18 or older
            if (age >= 18)
            {
                // Output if the person can vote
                Console.WriteLine($"The person's age is {age} and can vote.");
            }
            else
            {
                // Output if the person cannot vote
                Console.WriteLine($"The person's age is {age} and cannot vote.");
            }
        }
    }
}

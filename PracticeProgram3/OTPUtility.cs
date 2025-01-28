using System;

namespace PracticeProblem3
{
    public class OTPUtility
    {
        // Method to generate a 6-digit OTP using Math.Random()
        public static int GenerateOTP()
        {
            Random random = new Random();
            return random.Next(100000, 1000000); // Generate a number between 100000 and 999999
        }

        // Method to generate an array of 10 OTPs
        public static int[] GenerateOTPs(int count)
        {
            int[] otps = new int[count];
            for (int i = 0; i < count; i++)
            {
                otps[i] = GenerateOTP();
            }
            return otps;
        }

        // Method to check if OTPs are unique
        public static bool AreOTPsUnique(int[] otps)
        {
            for (int i = 0; i < otps.Length; i++)
            {
                for (int j = i + 1; j < otps.Length; j++)
                {
                    if (otps[i] == otps[j])
                    {
                        return false; // Duplicates found
                    }
                }
            }
            return true; // All OTPs are unique
        }

        // Display generated OTPs
        public static void DisplayOTPs(int[] otps)
        {
            Console.WriteLine("Generated OTPs:");
            foreach (int otp in otps)
            {
                Console.WriteLine(otp);
            }
        }
    

 
		public void Input()
        {
            int count = Convert.ToInt32(Console.ReadLine());
            
            // Generate 10 OTPs
            int[] otps = OTPUtility.GenerateOTPs(count);
            
            // Display the OTPs
            OTPUtility.DisplayOTPs(otps);
            
            // Check for uniqueness
            bool areUnique = OTPUtility.AreOTPsUnique(otps);
            Console.WriteLine($"\nAre all OTPs unique? {areUnique}");
        }
    }
}

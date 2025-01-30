using System;

namespace String_Functions
{
    class SubString
    {
        public void CountSubString()
        {
            Console.WriteLine("Enter the Main String: ");
            string? text = Console.ReadLine();

            Console.WriteLine("Enter the Sub String: ");
            string? sub = Console.ReadLine();

            if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(sub))
            {
                Console.WriteLine("No Value Provided.");
                return;
            }

            int count = 0;

            for (int i = 0; i <= text.Length - sub.Length; i++)  // Prevent out-of-bounds error
            {
                int j;
                for (j = 0; j < sub.Length; j++)
                {
                    if (text[i + j] != sub[j])
                        break;
                }
                if (j == sub.Length) // If the full substring is matched
                    count++;
            }

            Console.WriteLine($"Substring '{sub}' occurs {count} times in '{text}'.");
        }
    }
}

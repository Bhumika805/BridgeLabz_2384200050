using System;

namespace String_Functions
{
    class ToggleCase
    {
        public void ToggleCaseConverter()
        {
            Console.WriteLine("Enter the Words: ");
            string? input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("No Value Provided.");
                return;
            }

            string chars = "";
            foreach (char c in input)
            {
                if (Char.IsUpper(c))  // Corrected `char` to `Char`
                {
                    chars += Char.ToLower(c);  // Corrected `char` to `Char`
                }
                else if (Char.IsLower(c))  // Corrected `char` to `Char`
                {
                    chars += Char.ToUpper(c);  // Corrected `char` to `Char`
                }
                else
                {
                    chars += c; // Keep non-alphabetic characters as they are
                }
            }

            Console.WriteLine($"New Toggle case is: {chars}");
        }
    }
}

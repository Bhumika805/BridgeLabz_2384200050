using System;

namespace String_Functions
{
    class RemoveCharacter
    {
        public void RemoveCharFromString()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            Console.Write("Enter the character to remove: ");
            char charRemove = Console.ReadLine()[0];
			
			

            string result = "";
            
            // Loop through each character in the input string
            for (int i = 0; i < input.Length; i++)
            {
                // If the current character is not the one to remove, append it to the result string
                if (input[i] != charRemove)
                {
                    result += input[i];
                }
            }

            Console.WriteLine($"Modified String: \"{result}\"");
        }
    }
}

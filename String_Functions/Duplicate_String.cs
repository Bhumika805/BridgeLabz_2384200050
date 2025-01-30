using System;

namespace String_Functions
{
    class Duplicate_String
    {
        public void Duplicate()
        {
            Console.WriteLine("Enter the String: ");
            string input = Console.ReadLine();
            string str = "";  // No need to use nullable type for str

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("No Value Provided.");
                return;
            }

            for (int i = 0; i < input.Length; i++)
            {
                bool isDuplicate = false;

                // Check if input[i] already exists in 'str'
                for (int j = 0; j < str.Length; j++)
                {
                    if (input[i] == str[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                // If the character is not a duplicate, append it to 'str'
                if (!isDuplicate)
                {
                    str += input[i];
                }
            }

            Console.WriteLine($"New String is: {str}");
        }
    }
}

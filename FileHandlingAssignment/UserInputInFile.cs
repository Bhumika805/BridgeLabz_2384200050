using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlingAssignment
{
    internal class UserInputInFile
    {
        public void InputMethod(string filePath)
        {
            try
            {
                // Prompt user for their name
                Console.Write("Enter your name: ");
                string name = Console.ReadLine();

                // Prompt user for their age and ensure valid input
                Console.Write("Enter your age: ");
                int age;
                while (!int.TryParse(Console.ReadLine(), out age) || age <= 0)
                {
                    Console.Write("Error: Please enter a valid positive number for age: ");
                }

                // Prompt user for their favorite programming language
                Console.Write("Enter your favorite programming language: ");
                string favoriteLanguage = Console.ReadLine();

                // Open the file in append mode to add new user data without overwriting previous entries
                using (StreamWriter writer = new StreamWriter(filePath, append: true))
                {
                    // Write the user details into the file
                    writer.WriteLine($" Name: {name}");
                    writer.WriteLine($" Age: {age}");
                    writer.WriteLine($" Favorite Language: {favoriteLanguage}");
                    writer.WriteLine("---------------------------------"); // Separator for readability
                }

                // Inform the user that data has been saved successfully
                Console.WriteLine("User data saved successfully!");
            }
            catch (IOException ex)
            {
                // Handle exceptions related to file operations
                Console.WriteLine("An error occurred while writing to the file: " + ex.Message);
            }
        }
    }
}

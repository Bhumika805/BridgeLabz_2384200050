using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder_LinearAndBinarySearchAndStreamReader
{
    internal class UserInputIntoAFile
    {
        public void InputMethod()
        {
            string filePath = "C:\\Users\\91870\\Desktop\\New folder (5)/Testing.txt"; // File where user input will be stored

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, append: true)) // Append mode
                {
                    Console.WriteLine("Enter text to write to the file (type 'exit' to stop):");

                    while (true)
                    {
                        string userInput = Console.ReadLine();

                        if (userInput.Equals("exit", StringComparison.OrdinalIgnoreCase))
                            break;

                        writer.WriteLine(userInput); // Write user input to file
                    }
                }
                Console.WriteLine($"User input successfully written to {filePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing to file: {ex.Message}");
            }
        }
    }

}


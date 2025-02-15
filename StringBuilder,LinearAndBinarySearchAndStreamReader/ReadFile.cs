using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder_LinearAndBinarySearchAndStreamReader
{
    internal class ReadFile
    {
        public void InputMethod()
        {
            string filePath = "C:\\Users\\91870\\Desktop\\New folder (5)/Testing.txt"; // Change to the actual file path

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line); // Print each line
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file: {ex.Message}");
            }
        }
    }

}


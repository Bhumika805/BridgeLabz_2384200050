using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder_LinearAndBinarySearchAndStreamReader
{
    internal class ByteStreamtoCharacterStream
    {
        public void InputMethod()
        {
            string filePath = "C:\\Users\\91870\\Desktop\\New folder (5)/Testing.txt"; // Change to your actual file path

            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                using (StreamReader reader = new StreamReader(fs, Encoding.UTF8)) // Use appropriate encoding
                {
                    string content = reader.ReadToEnd(); // Read entire file
                    Console.WriteLine("File Content:");
                    Console.WriteLine(content);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file: {ex.Message}");
            }
        }
    }

}


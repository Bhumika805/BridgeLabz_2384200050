using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlingAssignment
{
        class LargeFileReader
        {
            public void ReadLargeFile(string filePath)
            {
                try
                {
                    if (!File.Exists(filePath))
                    {
                        Console.WriteLine("Error: The specified file does not exist.");
                        return;
                    }

                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string line;
                        int lineNumber = 0;

                        Console.WriteLine("Scanning file for lines containing 'error'...\n");

                        while ((line = reader.ReadLine()) != null)
                        {
                            lineNumber++;

                            // Case-insensitive check for "error"
                            if (line.IndexOf("error", StringComparison.OrdinalIgnoreCase) >= 0)
                            {
                                Console.WriteLine($"Line {lineNumber}: {line}");
                            }
                        }
                    }

                    Console.WriteLine("\nFile processing completed.");
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("Error: File not found.");
                }
                catch (IOException ex)
                {
                    Console.WriteLine("Error reading file: " + ex.Message);
                }
            }

            static void Main()
            {
                LargeFileReader fileReader = new LargeFileReader();
                Console.Write("Enter the file path: ");
                string filePath = Console.ReadLine();

                fileReader.ReadLargeFile(filePath);
            }
        }
}





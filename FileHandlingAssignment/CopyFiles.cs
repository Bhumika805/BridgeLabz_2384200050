using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlingAssignment
{
    internal class CopyFiles
    {
        // Method to handle file copying
        public void CopyFilesHandler(string SourceFile, string DestinationFile)
        {
            try
            {
                // Check if the source file exists
                if (!File.Exists(SourceFile))
                {
                    Console.WriteLine("File not found");
                    return; // Exit if the file doesn't exist
                }

                // Open the source file for reading
                using (FileStream fts = new FileStream(SourceFile, FileMode.Open, FileAccess.Read))
                using (StreamReader sr = new StreamReader(fts))
                {
                    // Read the entire content of the source file
                    string content = sr.ReadToEnd();

                    // Open (or create) the destination file for writing
                    using (FileStream fwriter = new FileStream(DestinationFile, FileMode.Create, FileAccess.Write))
                    using (StreamWriter writer = new StreamWriter(fwriter))
                    {
                        // Write the content into the destination file
                        writer.Write(content);
                    }

                    Console.WriteLine("File copied successfully!");
                }
            }
            catch (IOException ex)
            {
                // Handle any IO exceptions that may occur
                Console.WriteLine("An error occurred while handling the file: " + ex.Message);
            }
        }

        // Method to take user input for file paths
        public void InputMethod()
        {
            Console.Write("Enter the source file path: ");
            string SourceFile = Console.ReadLine(); // Read source file path from user

            Console.Write("Enter the destination file path: ");
            string DestinationFile = Console.ReadLine(); // Read destination file path from user

            // Call the file copy handler method
            CopyFilesHandler(SourceFile, DestinationFile);
        }
    }

}


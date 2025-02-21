using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlingAssignment
{
    public class FileConverter
    {
        public void ConvertUppercaseToLowercase(string inputFile, string outputFile)
        {
            try
            {
                // Ensure the source file exists
                if (!File.Exists(inputFile))
                {
                    Console.WriteLine("Error: Source file does not exist.");
                    return;
                }

                // Open input file with StreamReader and BufferedStream
                using (FileStream fs = new FileStream(inputFile, FileMode.Open, FileAccess.Read))
                using (BufferedStream bs = new BufferedStream(fs))
                using (StreamReader sr = new StreamReader(bs, Encoding.UTF8))
                using (FileStream outFs = new FileStream(outputFile, FileMode.Create, FileAccess.Write))
                using (StreamWriter sw = new StreamWriter(outFs, Encoding.UTF8))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        // Convert line to lowercase and write to output file
                        sw.WriteLine(line.ToLower());
                    }
                }

                Console.WriteLine("File successfully converted and saved as: " + outputFile);
            }
            catch (IOException ex)
            {
                Console.WriteLine("File error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error: " + ex.Message);
            }
        }
    }

    class Program3
    {
        static void Main()
        {
            string inputFile = "input.txt";   // Change this to your source file
            string outputFile = "output.txt"; // Output file name

            FileConverter converter = new FileConverter();
            converter.ConvertUppercaseToLowercase(inputFile, outputFile);
        }
    }

}

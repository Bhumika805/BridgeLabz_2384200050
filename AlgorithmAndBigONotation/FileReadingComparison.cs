using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace AlgorithmAndBigONotation
{
    class FileReadingComparison
    {
        public void FileReading()
        {
            string filePath = "largefile.txt"; // Ensure this file exists (500MB)

            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found. Please create a large test file (500MB).");
                return;
            }

            Console.WriteLine($"Reading {filePath} (500MB file)...");

            // Using StreamReader
            Stopwatch swStreamReader = Stopwatch.StartNew();
            ReadUsingStreamReader(filePath);
            swStreamReader.Stop();
            Console.WriteLine($"StreamReader Time: {swStreamReader.ElapsedMilliseconds} ms");

            // Using FileStream
            Stopwatch swFileStream = Stopwatch.StartNew();
            ReadUsingFileStream(filePath);
            swFileStream.Stop();
            Console.WriteLine($"FileStream Time: {swFileStream.ElapsedMilliseconds} ms");
        }

        // StreamReader (Reads character by character or line by line)
        public void ReadUsingStreamReader(string filePath)
        {
            using (StreamReader sr = new StreamReader(filePath, Encoding.UTF8))
            {
                while (sr.Read() != -1) { } // Read character by character
            }
        }

        // FileStream (Reads in chunks of bytes)
        public void ReadUsingFileStream(string filePath)
        {
            byte[] buffer = new byte[4096]; // Read in 4KB chunks
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                while (fs.Read(buffer, 0, buffer.Length) > 0) { } // Read bytes
            }
        }
    }

}

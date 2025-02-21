using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlingAssignment
{
    public class ImageConverter
    {
        // Convert image to byte array
        public byte[] ImageToByteArray(string imagePath)
        {
            try
            {
                return File.ReadAllBytes(imagePath);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error reading the image file: " + ex.Message);
                return null;
            }
        }

        // Convert byte array back to image
        public void ByteArrayToImage(byte[] byteArray, string outputImagePath)
        {
            try
            {
                if (byteArray == null)
                {
                    Console.WriteLine("Error: No data to write.");
                    return;
                }

                File.WriteAllBytes(outputImagePath, byteArray);
                Console.WriteLine("Image successfully written to: " + outputImagePath);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error writing the image file: " + ex.Message);
            }
        }

        // Compare original and copied images
        public void CompareFiles(string originalPath, string copiedPath)
        {
            try
            {
                FileInfo originalFile = new FileInfo(originalPath);
                FileInfo copiedFile = new FileInfo(copiedPath);

                if (originalFile.Length == copiedFile.Length)
                {
                    Console.WriteLine("Verification: The copied image is identical to the original.");
                }
                else
                {
                    Console.WriteLine("Warning: The copied image differs from the original.");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error comparing files: " + ex.Message);
            }
        }
    }

    class Program2
    {
        static void Main()
        {
            string originalImagePath = "input.jpg";  // Change this to your image file path
            string copiedImagePath = "output.jpg";   // Output file name

            ImageConverter converter = new ImageConverter();

            // Convert image to byte array
            byte[] imageBytes = converter.ImageToByteArray(originalImagePath);

            // Convert byte array back to an image
            converter.ByteArrayToImage(imageBytes, copiedImagePath);

            // Compare files
            converter.CompareFiles(originalImagePath, copiedImagePath);
        }
    }

}

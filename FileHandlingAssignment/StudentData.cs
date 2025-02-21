using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlingAssignment
{
    public class StudentData
    {
        private string filePath = "students.dat"; // Binary file path

        // Method to write student details to a binary file
        public void WriteStudentData(int rollNumber, string name, float gpa)
        {
            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Append, FileAccess.Write))
                using (BinaryWriter writer = new BinaryWriter(fs))
                {
                    writer.Write(rollNumber);
                    writer.Write(name);
                    writer.Write(gpa);
                }

                Console.WriteLine("Student data saved successfully.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error writing to file: " + ex.Message);
            }
        }

        // Method to read student details from the binary file
        public void ReadStudentData()
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    Console.WriteLine("No data found.");
                    return;
                }

                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                using (BinaryReader reader = new BinaryReader(fs))
                {
                    Console.WriteLine("Student Records:");
                    while (fs.Position < fs.Length)
                    {
                        int rollNumber = reader.ReadInt32();
                        string name = reader.ReadString();
                        float gpa = reader.ReadSingle();

                        Console.WriteLine($"Roll No: {rollNumber}, Name: {name}, GPA: {gpa:F2}");
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error reading from file: " + ex.Message);
            }
        }
    }

    class Program4
    {
        static void Main()
        {
            StudentData studentData = new StudentData();

            // Writing student data
            studentData.WriteStudentData(101, "Alice", 3.8f);
            studentData.WriteStudentData(102, "Bob", 3.6f);
            studentData.WriteStudentData(103, "Charlie", 3.9f);

            Console.WriteLine("\nRetrieving student data...\n");

            // Reading student data
            studentData.ReadStudentData();
        }
    }

}

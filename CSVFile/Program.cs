using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVFile
{
    public class Program
    {
        static void SwitchCase()
        {
            Console.WriteLine("Enter the question number :");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    ReadFile reader = new ReadFile();
                    reader.OnlyReadFile();
                    break;

                case 2:
                    Console.WriteLine("Starting program...");
                    WriteFile writer = new WriteFile();
                    writer.OnlyWriteFile();
                    Console.WriteLine("Program finished!");
                    break;

                case 3:
                    ReadandCount count = new ReadandCount();
                    count.OnlyReadFile();
                    break;

                case 4:
                    QualifyingStudents qualifyingStudents = new QualifyingStudents();
                    qualifyingStudents.FilterQualifiedStudents();
                    break;

                case 5:
                    SearchEmployee search = new SearchEmployee();
                    search.OnlyWriteFile();
                    break;

                default:
                    Console.WriteLine("Invalid Choice. Please choose correct question number.");
                    break;
            }
            
        }
        static void Main(string[] args)
        {
            SwitchCase();
        }
    }
}

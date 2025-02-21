using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlingAssignment
{
    internal class Program
    {
        static void SwitchCase()
        {
            Console.WriteLine("Enter the question number: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    CopyFiles files = new CopyFiles();
                    files.InputMethod();
                    break;

                case 2:
                    break;

                case 3:
                    break;
            }
        }
        static void Main(string[] args)
        {
            SwitchCase();
        }
    }
}

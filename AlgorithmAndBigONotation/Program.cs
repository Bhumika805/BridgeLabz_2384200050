using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndBigONotation
{
    internal class Program
    {
        static void SwitchCase()
        {
            Console.WriteLine("Enter the question number:");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    SearchComparison searchComparison = new SearchComparison();
                    searchComparison.Searching();
                    break;

                case 2:
                    SortingComparison sortingComparison = new SortingComparison();
                    sortingComparison.Sortings();
                    break;

                case 3:
                    StringConcatenationComparison st = new StringConcatenationComparison();
                    st.StringConcatenation();
                    break;

                case 4:
                    FileReadingComparison file = new FileReadingComparison();
                    file.FileReading();
                    break;

                case 5:
                    FibonacciExample example = new FibonacciExample();
                    example.Fibonacci();
                    break;

                default:
                    Console.WriteLine("invalid option");
                    break;
            }
        }
        
        static void Main(string[] args)
        {
            SwitchCase();
        }
    }
}

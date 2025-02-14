using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm
{
    public class BubbleSort
    {
        public void Sort(int[] marks)
        {
            int n = marks.Length;
            for (int i = 0; i < n - 1; i++)
            {
                bool swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (marks[j] > marks[j + 1])
                    {
                        int temp = marks[j];
                        marks[j] = marks[j + 1];
                        marks[j + 1] = temp;

                        swapped = true;
                    }
                }
                if (!swapped)
                    break;
            }
        }

        public void Print_Marks(int[] marks)
        {
            Console.WriteLine("Student marks are: ");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write(marks[i] + " ");
            }
            Console.WriteLine();
        }
        
        public void Method()
        {
            Console.Write("Enter the number of elements: ");
            int n = Convert.ToInt32(Console.ReadLine()); // Read array size

            int[] marks = new int[n]; // Declare array

            Console.WriteLine("Enter the elements:");
            for (int i = 0; i < n; i++)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine()); // Read elements
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(marks[i] + " ");
            }
            Console.WriteLine();

            Sort(marks);
            Console.WriteLine("Sorted array:");
            Print_Marks(marks);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm
{
    class EmployeeSorter
    {
        public void InsertionSort(int[] ids)
        {
            int n = ids.Length;
            for (int i = 1; i < n; i++)
            {
                int key = ids[i]; // Employee ID to insert
                int j = i - 1;

                // Shift larger elements to the right
                while (j >= 0 && ids[j] > key)
                {
                    ids[j + 1] = ids[j];
                    j--;
                }

                // Insert the key in the correct position
                ids[j + 1] = key;
            }
        }

        public void PrintArray(int[] ids)
        {
            Console.WriteLine("Employee IDs:");
            for (int i = 0; i < ids.Length; i++)
            {
                Console.Write(ids[i] + " ");
            }
            Console.WriteLine();
        }

        public void Employee_Method()
        {
            Console.Write("Enter the number of employees: ");
            int n = Convert.ToInt32(Console.ReadLine()); // Read size

            int[] ids = new int[n]; // Declare array

            Console.WriteLine("Enter Employee IDs:");
            for (int i = 0; i < n; i++)
            {
                ids[i] = Convert.ToInt32(Console.ReadLine()); // Read employee IDs
            }

            Console.WriteLine("Original Employee IDs:");
            PrintArray(ids);

            InsertionSort(ids); // Sort using Insertion Sort

            Console.WriteLine("Sorted Employee IDs:");
            PrintArray(ids);
        }
    }
}


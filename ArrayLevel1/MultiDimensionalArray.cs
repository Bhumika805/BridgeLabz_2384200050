using System;

namespace ArrayLevel1
{
    class MultiDimensionalArray
    {
        public void DimensionalArray()
        {
            Console.Write("Enter the number of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the number of columns: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            // Create a 2D array (matrix) with the given dimensions
            int[,] matrix = new int[rows, columns];

            Console.WriteLine("\nEnter the elements of the 2D array (matrix):");
            // Take user input for the matrix elements
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Element [{i},{j}]: ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Create a 1D array to store the elements of the matrix
            int[] array = new int[rows * columns];
            int index = 0; // Index for the 1D array

            // Copy the elements from the 2D array to the 1D array
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[index] = matrix[i, j];
                    index++;
                }
            }

            // Display the 1D array
            Console.WriteLine("\nThe 1D array (copied from the 2D array):");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace AlgorithmAndBigONotation
{
    class SortingComparison
    {
        public void Sortings()
        {
            int[] sizes = { 1000, 10000, 1000000 }; // Different dataset sizes
            Random rand = new Random();

            foreach (int size in sizes)
            {
                int[] data = new int[size];

                // Fill the array with random numbers
                for (int i = 0; i < size; i++)
                    data[i] = rand.Next(1, size * 10);

                Console.WriteLine($"\nSorting {size} elements:");

                // Bubble Sort (Skipped for large data to save time)
                if (size <= 10000)
                {
                    int[] bubbleData = (int[])data.Clone();
                    Stopwatch sw = Stopwatch.StartNew();
                    BubbleSort(bubbleData);
                    sw.Stop();
                    Console.WriteLine($"Bubble Sort: {sw.ElapsedMilliseconds} ms");
                }
                else
                {
                    Console.WriteLine("Bubble Sort: Skipped (Too slow)");
                }

                // Merge Sort
                int[] mergeData = (int[])data.Clone();
                Stopwatch swMerge = Stopwatch.StartNew();
                MergeSort(mergeData, 0, mergeData.Length - 1);
                swMerge.Stop();
                Console.WriteLine($"Merge Sort: {swMerge.ElapsedMilliseconds} ms");

                // Quick Sort
                int[] quickData = (int[])data.Clone();
                Stopwatch swQuick = Stopwatch.StartNew();
                QuickSort(quickData, 0, quickData.Length - 1);
                swQuick.Stop();
                Console.WriteLine($"Quick Sort: {swQuick.ElapsedMilliseconds} ms");
            }
        }

        // Bubble Sort (O(N²))
        public void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        // Merge Sort (O(N log N))
        public void MergeSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;
                MergeSort(arr, left, mid);
                MergeSort(arr, mid + 1, right);
                Merge(arr, left, mid, right);
            }
        }

        public void Merge(int[] arr, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;
            int[] L = new int[n1];
            int[] R = new int[n2];

            Array.Copy(arr, left, L, 0, n1);
            Array.Copy(arr, mid + 1, R, 0, n2);

            int i = 0, j = 0, k = left;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                    arr[k++] = L[i++];
                else
                    arr[k++] = R[j++];
            }
            while (i < n1) arr[k++] = L[i++];
            while (j < n2) arr[k++] = R[j++];
        }

        // Quick Sort (O(N log N))
        public void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);
                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }
        }

        public int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    (arr[i], arr[j]) = (arr[j], arr[i]); // Swap
                }
            }
            (arr[i + 1], arr[high]) = (arr[high], arr[i + 1]); // Swap pivot
            return i + 1;
        }
    }

}

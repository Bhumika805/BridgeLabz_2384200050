using System;

namespace PracticeProblem2
{
    public class RandomValueAnalyzer
    {
        // Method to generate an array of 4-digit random numbers
        public int[] Generate4DigitRandomArray(int size)
        {
            Random rand = new Random();
            int[] randomNumbers = new int[size];

            // Generate random 4-digit numbers
            for (int i = 0; i < size; i++)
            {
                randomNumbers[i] = rand.Next(1000, 10000); // Generates a 4-digit random number
            }

            return randomNumbers;
        }

        // Method to find the average, min, and max values of an array
        public double[] FindAverageMinMax(int[] numbers)
        {
            double[] results = new double[3];
            int sum = 0;
            int min = numbers[0];
            int max = numbers[0];

            foreach (int number in numbers)
            {
                sum += number;
                min = Math.Min(min, number);
                max = Math.Max(max, number);
            }

            // Calculate average
            results[0] = (double)sum / numbers.Length;
            results[1] = min;
            results[2] = max;

            return results;
        }
    }

    class RandomNumberAnalysis
    {
        public void RandomNum_Analysis()
        {
            RandomValueAnalyzer analyzer = new RandomValueAnalyzer();

            // Generate an array of 5 4-digit random numbers
            int[] randomNumbers = analyzer.Generate4DigitRandomArray(5);

            // Find average, min, and max
            double[] results = analyzer.FindAverageMinMax(randomNumbers);

            // Display the random numbers
            Console.WriteLine("Generated 4-digit random numbers:");
            foreach (int num in randomNumbers)
            {
                Console.WriteLine(num);
            }

            // Display the results
            Console.WriteLine("\nResults:");
            Console.WriteLine($"Average Value: {results[0]:F2}");
            Console.WriteLine($"Minimum Value: {results[1]}");
            Console.WriteLine($"Maximum Value: {results[2]}");
        }
    }
}

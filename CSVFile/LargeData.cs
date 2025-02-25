using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVFile
{
    class LargeData
    {
        static void Main()
        {
            string filePath = @"E:\github\CSVFolderText\LargeData.csv"; // Update with actual file path
            int batchSize = 100; // Process 100 records at a time
            int totalProcessed = 0;

            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found.");
                return;
            }

            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Read();
                csv.ReadHeader(); // Read and skip the header row

                while (csv.Read())
                {
                    var batch = csv.EnumerateRecords(new Record()).Take(batchSize).ToList();

                    if (batch.Count == 0) break; // Stop if no more records

                    totalProcessed += batch.Count;
                    Console.WriteLine($"Processed {totalProcessed} records...");

                    // Simulate processing (e.g., insert into database, transform, etc.)
                }
            }

            Console.WriteLine($"Finished processing {totalProcessed} records.");
        }
    }

    class Record
    {
        public string Column1 { get; set; }
        public string Column2 { get; set; }
        public string Column3 { get; set; }
    }

}


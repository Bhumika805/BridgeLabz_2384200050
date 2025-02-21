using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FileHandlingAssignment
{
    class PipeStreamExample
    {
        private static AnonymousPipeServerStream pipeServer;
        private static AnonymousPipeClientStream pipeClient;

        static void Main()
        {
            // Create pipe server and client
            pipeServer = new AnonymousPipeServerStream(PipeDirection.Out, HandleInheritability.Inheritable);
            pipeClient = new AnonymousPipeClientStream(PipeDirection.In, pipeServer.GetClientHandleAsString());

            // Create threads for writing and reading
            Thread writerThread = new Thread(WriterThread);
            Thread readerThread = new Thread(ReaderThread);

            writerThread.Start();
            readerThread.Start();

            // Wait for both threads to finish
            writerThread.Join();
            readerThread.Join();

            Console.WriteLine("Inter-thread communication completed.");
        }

        // Writer Thread - Writes data to PipeStream
        static void WriterThread()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(pipeServer, Encoding.UTF8, 1024, leaveOpen: false))
                {
                    writer.AutoFlush = true;
                    string[] messages = { "Hello", "This is a pipe stream example", "C# multi-threading", "End" };

                    foreach (var message in messages)
                    {
                        Console.WriteLine("[Writer] Writing: " + message);
                        writer.WriteLine(message);
                        Thread.Sleep(500); // Simulate processing time
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("[Writer] Error: " + ex.Message);
            }
            finally
            {
                pipeServer.Dispose();
            }
        }

        // Reader Thread - Reads data from PipeStream
        static void ReaderThread()
        {
            try
            {
                using (StreamReader reader = new StreamReader(pipeClient, Encoding.UTF8))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine("[Reader] Received: " + line);
                        if (line == "End") break; // Stop reading on termination message
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("[Reader] Error: " + ex.Message);
            }
            finally
            {
                pipeClient.Dispose();
            }
        }
    }

}

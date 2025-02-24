using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnotationProgram
{

    public class MaxLength
    {
        [LogExecutionTime]
        public void LongRunningMethod1()
        {
            System.Threading.Thread.Sleep(2000); // Simulate long running task
        }

        [LogExecutionTime]
        public void LongRunningMethod2()
        {
            System.Threading.Thread.Sleep(1000); // Simulate shorter task
        }
    }

    class MaxLengthAttribute
    {
        static void Main()
        {
            var example = new Example();
            MeasureExecutionTime(example, nameof(example.LongRunningMethod1));
            MeasureExecutionTime(example, nameof(example.LongRunningMethod2));
        }

        static void MeasureExecutionTime(Example example, string methodName)
        {
            var methodInfo = typeof(Example).GetMethod(methodName);
            if (methodInfo.GetCustomAttributes(typeof(LogExecutionTime), false).Length > 0)
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                methodInfo.Invoke(example, null);
                stopwatch.Stop();
                Console.WriteLine($"{methodName} Execution Time: {stopwatch.ElapsedMilliseconds} ms");
            }
        }

    }
}

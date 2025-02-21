using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program8
    {
        static void Method1()
        {
            int v = 10 / 0;
            int result = v; // This will throw an ArithmeticException
        }

        static void Method2()
        {
            Method1(); // Exception propagates from here
        }

        static void Main()
        {
            try
            {
                Method2(); // Calls Method2(), which calls Method1()
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("Handled exception in Main");
            }
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder_LinearAndBinarySearchAndStreamReader
{
    internal class StringBuilderQues
    {
        StringBuilder sb = new StringBuilder(5000);
        public void Operation(int n )
        {
            for (int i = 0; i < n; i++)
            { 
                sb.Append(Console.ReadLine()).Append(" ");
            }

            Console.WriteLine(sb);
        }

        
        public void appendNewLine(string str) => sb.AppendLine(str);
        public void replaceWord(string str1, string str2) 
        {
            sb.Replace(str1, str2);
            Console.WriteLine(sb);
        }
        public void clearString() => sb.Clear();
    }
}

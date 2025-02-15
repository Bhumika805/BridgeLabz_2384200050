using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder_LinearAndBinarySearchAndStreamReader
{
    internal class ConcatenateStrings
    {
         public string ConcatenateString(string[] words)
        {
            StringBuilder sb = new StringBuilder();

            foreach (string word in words)
            {
                sb.Append(word); // Append each string to StringBuilder
            }

            return sb.ToString(); // Convert StringBuilder to string
        }
    }
}

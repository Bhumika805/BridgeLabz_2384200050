using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder_LinearAndBinarySearchAndStreamReader
{
    public  class ReverseString
    {
        public string Reverse(string str) { 
        
            StringBuilder sb = new StringBuilder();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }

            return sb.ToString();
        }
    }
}

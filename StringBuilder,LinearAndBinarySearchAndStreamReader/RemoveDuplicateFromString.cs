using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder_LinearAndBinarySearchAndStreamReader
{
    internal class RemoveDuplicateFromString
    {
        public string RemoveDuplicate(string str)
        { 
            StringBuilder sb = new StringBuilder();
            HashSet<char> list = new HashSet<char>();

            foreach (char c in str) 
            {
                if (!list.Contains(c))
                {
                    sb.Append(c);
                    list.Add(c);
                }
            }

            return sb.ToString();
        }
    }
}

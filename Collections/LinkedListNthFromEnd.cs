using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class LinkedListNthFromEnd
    {
        public static string FindNthFromEnd(LinkedList<string> list, int n)
        {
            LinkedListNode<string> slow = list.First;
            LinkedListNode<string> fast = list.First;

            // Move fast pointer N steps ahead
            for (int i = 0; i < n; i++)
            {
                if (fast == null) return "N is larger than the list size"; // Handle invalid N
                fast = fast.Next;
            }

            // Move both slow and fast one step at a time
            while (fast != null)
            {
                slow = slow.Next;
                fast = fast.Next;
            }

            return slow != null ? slow.Value : "Invalid Input";
        }

        public void DisplayNthFromEnd()
        {
            LinkedList<string> list = new LinkedList<string>(new string[] { "A", "B", "C", "D", "E" });
            int N = 2;

            string result = FindNthFromEnd(list, N);
            Console.WriteLine($"The {N}th element from the end is: {result}");
        }
    }

}

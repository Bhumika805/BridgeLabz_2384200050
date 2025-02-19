using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class ReverseArray
    {
        // Reverse ArrayList 
        public static void ReverseArrayList(ArrayList list)
        {
            int left = 0, right = list.Count - 1;
            while (left < right)
            {
                object temp = list[left];
                list[left] = list[right];
                list[right] = temp;
                left++;
                right--;

            }
        }

        // Reverse LinkedList 
        public static LinkedList<int> ReverseLinkedList(LinkedList<int> list)
        {
            LinkedList<int> reversedList = new LinkedList<int>();
            foreach (int item in list)
            {
                reversedList.AddFirst(item);
            }
            return reversedList;
        }

        public void Display()
        {
            
            ArrayList arrayList = new ArrayList { 1, 2, 3, 4, 5 };
            ReverseArrayList(arrayList);
            Console.WriteLine("Reversed ArrayList: " + string.Join(", ", arrayList.ToArray()));

            
            LinkedList<int> linkedList = new LinkedList<int>(new int[] { 1, 2, 3, 4, 5 });
            LinkedList<int> reversedLinkedList = ReverseLinkedList(linkedList);
            Console.WriteLine("Reversed LinkedList: " + string.Join(", ", reversedLinkedList));
        }
    }
}


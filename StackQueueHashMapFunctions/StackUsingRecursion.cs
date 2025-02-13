using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueueHashMapFunctions
{
    using System;

    namespace StackQueueHashMapFunctions
    {
        public class Node_Stack
        {
            public int Data;
            public Node_Stack Next; // Fixed missing semicolon

            public Node_Stack(int data)
            {
                this.Data = data;
                this.Next = null;
            }
        }

        public class Stack_Recursion
        {
            public Node_Stack top;

            public void Push(int data)
            {
                Node_Stack newNode = new Node_Stack(data);
                newNode.Next = top;
                top = newNode;
            }

            public int Pop()
            {
                if (IsEmpty())
                    return -1; // Return -1 instead of default(int) to indicate stack is empty

                int data = top.Data;
                top = top.Next;
                return data;
            }

            public bool IsEmpty()
            {
                return top == null;
            }

            // Recursively sort the stack
            public void SortStack()
            {
                if (!IsEmpty())
                {
                    int temp = Pop(); // Pop the top element
                    SortStack(); // Recursively sort the rest of the stack
                    InsertSorted(temp); // Insert the popped element back in sorted order
                }
            }

            // Insert an element into the sorted stack
            private void InsertSorted(int item)
            {
                if (IsEmpty() || top.Data <= item)
                {
                    Push(item);
                    return;
                }

                int temp = Pop(); // Pop the top element
                InsertSorted(item); // Recursive call
                Push(temp); // Push back the stored element
            }

            public void Display()
            {
                Node_Stack temp = top;
                Console.Write("Stack elements (Top to Bottom): ");
                while (temp != null) // Traverse through stack
                {
                    Console.Write(temp.Data + " "); // Print data
                    temp = temp.Next; // Move to next node
                }
                Console.WriteLine(); // Print newline for better formatting
            }
        }

        internal class StackUsingRecursion
        {
            public void Method()
            {
                Stack_Recursion stack = new Stack_Recursion(); // Use correct class

                // Ask user for the number of elements
                Console.Write("Enter the number of elements to push: ");
                int n = int.Parse(Console.ReadLine());

                // Push elements onto the stack
                for (int i = 0; i < n; i++)
                {
                    Console.Write("Enter element " + (i + 1) + ": ");
                    int item = int.Parse(Console.ReadLine());
                    stack.Push(item);
                }

                // Display original stack
                Console.WriteLine("Original Stack:");
                stack.Display();

                // Sort the stack using recursion
                stack.SortStack();

                // Display sorted stack
                Console.WriteLine("Sorted Stack:");
                stack.Display();
            }
        }
    }
}


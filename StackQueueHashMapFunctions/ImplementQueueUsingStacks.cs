using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StackQueueHashMapFunctions
{
    public class Node
    {
        public int Data;
        public Node Next;
        public Node(int data)
        {
            this.Data = data;
            this.Next = null;
        }
    }

    public class Stack
    {
        public Node top;
        public void Push(int Data)
        {
            Node newNode = new Node(Data);
            newNode.Next = top;
            top = newNode;
        }

        public int Pop()
        {
            if (top == null)
                return default(int);

            int data = top.Data;
            top = top.Next;
            return data;
        }

        public bool IsEmpty()
        {
            return top == null; 
        }

        public void DisplayStack()
        {
            Node temp = top;
            Console.WriteLine("This is the Stack(Top to Bottom): ");
            while(temp != null)
            {
                Console.WriteLine(temp.Data + " ");
                temp = temp.Next;
            }
            Console.WriteLine();
        }
    }

    internal class ImplementQueueUsingStacks
    {
        private Stack stack1 = new Stack();
        private Stack stack2 = new Stack();

        public void Enqueue(int Data)
        {
            stack1.Push(Data);
        }

        public int Dequeue()
        {
            if(stack2.IsEmpty())
            {
                while(!stack1.IsEmpty())
                {
                    stack2.Push(stack1.Pop());
                }
            }
            return stack2.Pop();
        }

        public void DisplayStack1()
        {
            Console.WriteLine("Stack1 contents before Dequeue:");
            stack1.DisplayStack();
        }

    }

    public class QueueMethod
    {
        public Node top;
        public void queueStacks()
        {
            ImplementQueueUsingStacks queue = new ImplementQueueUsingStacks();

            queue.Enqueue(15);
            queue.Enqueue(20);
            queue.Enqueue(2);
            queue.Enqueue(10);
            queue.Enqueue(6);
            queue.Enqueue(7);

            queue.DisplayStack1();

            Console.WriteLine("There are using two Stacks for making a Queue.");
            
            Console.WriteLine("Correct Queue:");

            Console.WriteLine();

            for (int i=0; i<6; i++)
            {
                Console.Write(queue.Dequeue() + " ");
            }
        }

       
            
        

        
    }
}

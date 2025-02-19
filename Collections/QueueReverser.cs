using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class QueueReverser
    {
        public static Queue<int> ReverseQueue(Queue<int> queue)
        {
            Stack<int> stack = new Stack<int>();

            // Dequeue elements and push onto stack
            while (queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }

            // Pop from stack and enqueue back to queue
            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }

            return queue;
        }

        public void DisplayReverseQueue()
        {
            Queue<int> queue = new Queue<int>(new[] { 10, 20, 30 });
            Queue<int> reversedQueue = ReverseQueue(queue);

            Console.WriteLine("Reversed Queue: " + string.Join(", ", reversedQueue));
        }
    }

}

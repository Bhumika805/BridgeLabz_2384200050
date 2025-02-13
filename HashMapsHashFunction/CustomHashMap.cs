using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashMapsHashFunction
{
        public class HashNode
        {
            public int Key;
            public int Value;
            public HashNode Next;

            public HashNode(int key, int value)
            {
                Key = key;
                Value = value;
                Next = null;
            }
        }

        // Custom Hash Map using Separate Chaining
        public class CustomHashMap
        {
            private const int SIZE = 10; // Fixed bucket size
            private HashNode[] buckets;

            public CustomHashMap()
            {
                buckets = new HashNode[SIZE];
            }

            // Hash function to get the index
            private int GetIndex(int key)
            {
                return key % SIZE; // Modulo operation for index
            }

            // Insert key-value pair
            public void Put(int key, int value)
            {
                int index = GetIndex(key);
                HashNode head = buckets[index];

                // Check if key exists, update value
                while (head != null)
                {
                    if (head.Key == key)
                    {
                        head.Value = value; // Update value if key already exists
                        return;
                    }
                    head = head.Next;
                }

                // If key doesn't exist, insert at head (Separate Chaining)
                HashNode newNode = new HashNode(key, value);
                newNode.Next = buckets[index];
                buckets[index] = newNode;
            }

            // Retrieve value by key
            public int Get(int key)
            {
                int index = GetIndex(key);
                HashNode head = buckets[index];

                while (head != null)
                {
                    if (head.Key == key)
                        return head.Value; // Return value if found

                    head = head.Next;
                }

                return -1; // Return -1 if key not found
            }

            // Remove key-value pair
            public void Remove(int key)
            {
                int index = GetIndex(key);
                HashNode head = buckets[index];
                HashNode prev = null;

                while (head != null)
                {
                    if (head.Key == key)
                    {
                        if (prev == null)
                            buckets[index] = head.Next; // Remove head node
                        else
                            prev.Next = head.Next; // Remove intermediate node

                        return;
                    }
                    prev = head;
                    head = head.Next;
                }
            }

            // Display hash map (for debugging)
            public void Display()
            {
                for (int i = 0; i < SIZE; i++)
                {
                    Console.Write($"Bucket {i}: ");
                    HashNode head = buckets[i];
                    while (head != null)
                    {
                        Console.Write($"[{head.Key} -> {head.Value}] ");
                        head = head.Next;
                    }
                    Console.WriteLine();
                }
            }
        }

}


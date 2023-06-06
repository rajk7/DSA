using System;
using System.Collections.Generic;

class PriorityQueue
{
    public static void Main(string[] args)
    {
        //Priority Queue = A FIFO data structure that serves elements
        //                             with the highest priorities first 
        //				  before elements with lower priority

        //Strings in default order

        PriorityQueue<string, int> queue = new PriorityQueue<string, int>();
        queue.Enqueue("Item A", 0);
        queue.Enqueue("Item B", 60);
        queue.Enqueue("Item C", 2);
        queue.Enqueue("Item D", 1);

        while (queue.TryDequeue(out string item, out int priority))
        {
            Console.WriteLine($"Popped Item : {item}. Priority Was : {priority}");
        }

    }

}

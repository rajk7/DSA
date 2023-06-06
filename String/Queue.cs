using System;
using System.Collections;
using System.Collections.Generic;

public class Queue
{
    public static void Main(string[] args)
    {
        #region What is

        // *****************************************************

        // Queue = FIFO data structure. First-In First-Out
        //		   A collection designed for holding elements prior to processing
        //		   Linear data structure

        //         enqueue = offer()
        //         dequeue = Dequeue()

        // Where are queues useful?

        // 1. Keyboard Buffer (letters should appear on the screen in the order they're pressed)
        // 2. Printer Queue (Print jobs should be completed in order)
        // 3. Used in LinkedLists, PriorityQueues, Breadth-first search

        // *****************************************************
        #endregion

        Queue<String> queue = new Queue<String>();

        queue.Enqueue("Karen");
        queue.Enqueue("Chad");
        queue.Enqueue("Steve");
        queue.Enqueue("Harold");

        //Console.WriteLine(queue.Size());
        Console.WriteLine(queue.Contains("Harold"));

        Console.WriteLine(queue.Peek());
        queue.Dequeue();
        //queue.Dequeue();
        //queue.Dequeue();
        //queue.Dequeue();
        Console.WriteLine(string.Join("\n", queue));
    }
}


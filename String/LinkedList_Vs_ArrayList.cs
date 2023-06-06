using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

// InComplite 
public class LinkedList_Vs_ArrayList
{
    public static void Main(String[] args)
    {

        LinkedList<int> linkedList = new LinkedList<int>();
        ArrayList arrayList = new ArrayList();

        DateTime startTime;
        DateTime endTime;
        TimeSpan elapsedTime;

        for (int i = 0; i < 1000000; i++)
        {
            linkedList.AddLast(i);
            arrayList.Add(i);
        }

        // ****************LinkedList****************
        startTime = DateTime.Now;

        //linkedList.Find(0);
        //linkedList.Find(500000);
        //linkedList.Find(999999);
        //linkedList.Remove(0);
        //linkedList.Remove(500000);
        linkedList.Remove(999999);

        endTime = DateTime.Now;

        elapsedTime = endTime - startTime;

        Console.WriteLine("LinkedList:\t" + elapsedTime.TotalMilliseconds + " ms");

        // ****************ArrayList****************	

        startTime = DateTime.Now;

        //arrayList.IndexOf(0);
        //arrayList.IndexOf(500000);
        //arrayList.Get(999999);
        //arrayList.Remove(0);
        //arrayList.Remove(500000);
        arrayList.Remove(999999);

        endTime = DateTime.Now;

        elapsedTime = endTime - startTime;
        Console.WriteLine();
        Console.WriteLine("ArrayList:\t" + elapsedTime.TotalMilliseconds + " ms");

    }

    private static long nanoTime()
    {
        long nano = 10000L * Stopwatch.GetTimestamp();
        nano /= TimeSpan.TicksPerMillisecond;
        nano *= 100L;
        return nano;
    }
}

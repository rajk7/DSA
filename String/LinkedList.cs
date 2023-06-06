using System;
using System.Collections.Generic;

public class LinkedList
{
	public static void Main(string[] args)
	{
        // Create a list of strings  
        var names = new LinkedList<string>();
        names.AddLast("Sonoo");
        names.AddLast("Ankit");
        names.AddLast("Peter");
        names.AddLast("Irfan");

        //insert new element before "Peter"  
        LinkedListNode<String> node = names.Find("Peter");
        names.AddBefore(node, "John");
        names.AddAfter(node, "Lucy");

        names.Remove("Ankit"); 
        names.RemoveLast(); // remove's Irfan
        names.RemoveFirst(); // remove's Sonoo
        names.AddFirst("Printer");

        // Iterate list element using foreach loop  
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }
}
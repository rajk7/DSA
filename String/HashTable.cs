using System;
using System.Collections;

public class HashTable
{
    public static void Main(String[] args)
    {

        // Hashtable = A data structure that stores unique keys to values ex.<Integer, String>
        //			   Each key/value pair is known as an Entry
        //			   FAST insertion, look up, deletion of key/value pairs
        // 			   Not ideal for small data sets, great with large data sets

        // hashing = Takes a key and computes an integer (formula will vary based on key & data type)
        //		       In a Hashtable, we use the hash % capacity to calculate an index number 

        //			key.hashCode() % capacity = index  

        // bucket = an indexed storage location for one or more Entries
        //	            can store multiple Entries in case of a collision (linked similarly a LinkedList)

        // collision = hash function generates the same index for more than one key
        //			less collisions = more efficiency

        // Runtime complexity: Best Case O(1)
        //                                     Worst Case O(n)

        Hashtable table = new Hashtable(21);


        table.Add(100, "Spongebob");
        table.Add(123, "Patrick");
        table.Add(321, "Sandy");
        table.Add(555, "Squidward");
        table.Add(777, "Gary");

        //table.Remove(777);

        foreach (DictionaryEntry key in table)
        {
            Console.WriteLine((key.GetHashCode() % 21 + "\t" + key.Key + "\t" + key.Value));
        }

        Console.ReadKey();
    }
}

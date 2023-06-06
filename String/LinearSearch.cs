using System;


public class LinearSearch
{
    public static void Main(String[] args)
    {
        #region Linear search

        // linear search = Iterate through a collection one element at a time

        //      runtime complexity: O(n)

        //      Disadvantages:
        //          Slow for large data sets

        //      Advantages:
        //          Fast for searches of small to medium data sets
        //          Does not need to sorted
        //          Useful for data structures that do not have random access(Linked List)
        #endregion

        int[] array = { 9, 1, 8, 2, 7, 3, 6, 4, 5 };

        int index = linearSearch(array, 6);

        if (index != -1)
        {
            Console.WriteLine("Element found at index: " + index);
        }
        else
        {
            Console.WriteLine("Element not found");
        }

    }

    private static int linearSearch(int[] array, int value)
    {
        
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == value)
            {
                return i;
            }
        }

        return -1;
    }
}


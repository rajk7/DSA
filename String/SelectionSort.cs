using System;

public class SelectionSort
{
    // selection sort = search through an array and keep track of the minimum value during 
    //			         each iteration. At the end of each iteration, we swap values.

    //				 Quadratic time O(n^2)
    //				 small data set = okay
    //				 large data set = BAD

    public static void Main(String[] args)
    {

        int[] array = { 8, 7, 9, 2, 3, 1, 5, 4, 6 };

        selectionSort(array);

        foreach (var i in array)
        {
            Console.Write(i + ", ");
        }
    }

    private static void selectionSort(int[] array)
    {

        for (int i = 0; i < array.Length - 1; i++)
        {
            int min = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[min] > array[j])
                {
                    min = j;
                }
            }

            int temp = array[i];
            array[i] = array[min];
            array[min] = temp;
        }

    }
}

using System;
using System.Linq;
using System.Collections.Generic;


public class EvenNumber
{
    public static void Main(string[] args)
    {
        List<int> numList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
		List<int> evenNum = numList.Where(x => x % 2 == 0).ToList();
        
        for(int i = 0; i< evenNum.Count; i++)
        {
            Console.WriteLine(evenNum[i]);
        }
    }    
}

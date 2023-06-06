using System;

public class ReversingString
{
	public static void Main()
	{
            
        string x = "Hello World";
        char[] ch = x.ToCharArray();
        int size = ch.Length;
        char[] newString = new char[size];
        for (int i = 0; i < size; i++)
        {
            newString[size -1 - i] = ch[i];
        }
        //Console.WriteLine("char "+ch[6]);
        Console.WriteLine(ch);
        Console.WriteLine(newString);
            
    }
}


using System;

public class FirstLetterUpperCase
{
	public static void Main()
	{
        string x = " this  is my home";
        char[] a = x.ToCharArray();
        int size = x.Length;
        //char[] b = new char[size];
        if (a[0] != ' ')
        {
            a[0] = (char)(a[0] - 32);

        }
        for (int i = 0; i < size; i++)
        {

            if (a[i] == ' ' && a[i + 1] != ' ')
            {
                a[i + 1] = (char)(a[i + 1] - 32);
            }
        }

        Console.WriteLine(x);
        Console.WriteLine(a);
        Console.ReadLine();
    }
}



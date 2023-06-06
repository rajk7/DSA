using System;

public class Palindrome
{
    public static void Main(string[] args)
    {
        //palindrome
            
        string x = "wow";
        char[] a = x.ToCharArray();
        int size = x.Length;

        char[] newA = new char[size];
        for (int i = 0; i < size; i++)
        {
            newA[size-1-i] = a[i];
                
                
        }
            
        for (int i = 0; i < size; i++)
        {
            if (newA[i] != a[i])
            {
                Console.WriteLine(x + " NO this is palindrome");
                Environment.Exit(0);
            }
            else
            {
                continue;
            }
        }
        Console.WriteLine(x + " YES this is palindrome");
            
    }
}


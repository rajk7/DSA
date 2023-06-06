using System;

public class CloneVsCopyTo
{
	public static void Main()
	{
        //copyTo and clone

        string x = "Hello World";
        char[] ch = new char[15];
        string clone = (string)x.Clone();
        x.CopyTo(0, ch, 1, 9);

        Console.WriteLine(clone);
        Console.WriteLine(ch);
    }
}

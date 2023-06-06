using System;

public class Recursion
{
    // recursion = When a thing is defined in terms of itself. - Wikipedia
    //			   Apply the result of a procedure, to a procedure.  
    //			   A recursive method calls itself. Can be a substitute for iteration.
    //			   Divide a problem into sub-problems of the same type as the original.
    //			   Commonly used with advanced sorting algorithms and navigating trees

    //			   Advantages
    //			   ----------
    //			   easier to read/write
    //			   easier to debug

    //			   Disadvantages
    //			   ----------
    //			   sometimes slower
    //			   uses more memory

    public static void Main(String[] args)
    {

        walk(5);
        Console.WriteLine(factorial(7));
        Console.WriteLine(Power(2, 8));
    }

    private static void walk(int steps)
    {

        if (steps < 1) return; //base case
        Console.WriteLine("You take a step!");
        walk(steps - 1); //recursive case
    }
    private static int factorial(int num)
    {

        if (num < 1) return 1; //base case
        return num * factorial(num - 1); //recursive case
    }

    private static int Power(int base1, int power)
    {

        if (power < 1) return 1; //base case
        return base1 * Power(base1, power - 1); //recursive case
    }
}

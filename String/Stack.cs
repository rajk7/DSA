using System;
using System.Collections.Generic;

public class Stack
{

    public static void Main(string[] args)
    {
        #region What is

        // *****************************************************

        // stack = LIFO data structure. Last-In First-Out
        //               stores objects into a sort of "vertical tower"
        //		  push() to add objects to the top
        //		  pop() to remove objects from the top

        // uses of stacks?
        // 1. undo/redo features in text editors
        // 2. moving back/forward through browser history
        // 3. backtracking algorithms (maze, file directories)
        // 4. calling functions (call stack)

        // *****************************************************
        #endregion

        Stack<string> stacks = new Stack<string>();

        //Console.WriteLine(stack.Empty);

        if (stacks.Count > 0)
            stacks.Pop();

        stacks.Push("Minecraft");
        stacks.Push("Skyrim");
        stacks.Push("DOOM");
        stacks.Push("Borderlands");
        stacks.Push("FFVII");

        //string myFavGame = stacks.Pop();
        //Console.WriteLine(stacks.Peek());
        //Console.WriteLine(stacks.Contains("Minecraft"));

        Console.WriteLine(string.Join("\n", stacks));

        //foreach (var stack in stacks)
        //{
        //    Console.Write(stack + " ");
        //}

    }
}
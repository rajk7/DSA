using System;
using System.Collections.Generic;

class BFS
{


    public static void Main(String[] args)
    {

        // Breadth FS = Traverse a graph level by level
        //			   Utilizes a Queue
        //			   Better if destination is on average close to start
        //			   Siblings are visited before children

        // Depth FS   = Traverse a graph branch by branch
        //			   Utilizes a Stack
        //			   Better if destination is on average far from the start
        //			   Children are visited before siblings
        //			   More popular for games/puzzles

        Graph4 graph = new Graph4(5);

        graph.addNode(new Node('A'));
        graph.addNode(new Node('B'));
        graph.addNode(new Node('C'));
        graph.addNode(new Node('D'));
        graph.addNode(new Node('E'));

        graph.addEdge(0, 1);
        graph.addEdge(1, 2);
        graph.addEdge(1, 4);
        graph.addEdge(2, 3);
        graph.addEdge(2, 4);
        graph.addEdge(4, 0);
        graph.addEdge(4, 2);

        graph.print();

        graph.breadthFirstSearch(0);
    }
}

public class Graph4
{

    List<Node> nodes;
    int[,] matrix;

    public Graph4(int size)
    {

        nodes = new List<Node>();
        matrix = new int[size, size];
    }
    public void addNode(Node node)
    {

        nodes.Add(node);
    }
    public void addEdge(int src, int dst)
    {

        matrix[src, dst] = 1;
    }
    public bool checkEdge(int src, int dst)
    {

        if (matrix[src, dst] == 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public void print()
    {

        Console.Write("  ");
        foreach (var node in nodes)
        {
            Console.Write(node.data + " ");
        }
        Console.WriteLine();

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            Console.Write(nodes[i].data + " ");
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    public void breadthFirstSearch(int src)
    {
        Queue<int> queue = new Queue<int>();
        bool[] visited = new bool[matrix.Length];

        queue.Enqueue(src);
        visited[src] = true;

        while (queue.Count != 0)
        {

            src = queue.Dequeue();
            Console.WriteLine(nodes[src].data + " = visited");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[src, i] == 1 && !visited[i])
                {
                    queue.Enqueue(i);
                    visited[i] = true;
                }
            }
        }
    }
}
//public class Node4
//{

//    char data;

//    Public Node4(char data)
//    {
//        this.data = data;
//    }
//}
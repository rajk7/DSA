using System;
using System.Collections.Generic;

class DFS
{
    public static void Main(String[] args)
    {

        // Depth First Search = Pick a route, keep going.
        //					 If you reach a dead end, or an already visited node,
        //					 backtrack to a previous node with unvisited adjacent neighbors

        Graph3 graph = new Graph3(5);

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

        graph.depthFirstSearch(0);
    }
}

public class Graph3
{

    List<Node> nodes;
    int[,] matrix;

    public Graph3(int size)
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
    public void depthFirstSearch(int src)
    {
        bool[] visited = new bool[matrix.Length];
        dFSHelper(src, visited);
    }
    private void dFSHelper(int src, bool[] visited)
    {

        if (visited[src])
        {
            return;
        }
        else
        {
            visited[src] = true;
            Console.WriteLine(nodes[src].data + " = visited");
        }

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (matrix[src, i] == 1)
            {
                dFSHelper(i, visited);
            }
        }
        return;
    }

    //public class Node3
    //{

    //    char data;

    //    Public Node3(char data)
    //    {
    //        this.ata = data;
    //    }
    //}
}

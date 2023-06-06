using System;
using System.Collections.Generic;

public class Graph
{

    List<Node> nodes;
    int[,] matrix;

    public Graph(int size)
    {
        nodes = new List<Node>(size - 1);
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
        foreach (Node node in nodes)
        {
            Console.Write(node.data + " ");
        }
        Console.WriteLine();

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            Console.Write(nodes[i].data + " ");

            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }

            Console.WriteLine();
        }
    }
}

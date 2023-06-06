using System;
using System.Collections.Generic;

public class Graph2
{
    List<List<Node>> alist;

    public Graph2()
    {
        alist = new List<List<Node>>();
    }

    public void addNode(Node node)
    {
        List<Node> currentList = new List<Node>();
        currentList.Add(node);
        alist.Add(currentList);
    }
    public void addEdge(int src, int dst)
    {
        List<Node> currentList = alist[src];
        Node dstNode = alist[dst][0];
        currentList.Add(dstNode);
    }

    public bool checkEdge(int src, int dst)
    {
        List<Node> currentList = alist[src];
        Node dstNode = alist[dst][0];

        foreach (var node in currentList)
        {
            if (node == dstNode)
            {
                return true;
            }
        }
        return false;
    }

    public void print()
    {
        foreach (List<Node> currentList in alist)
        {
            foreach (var node in currentList)
            {
                Console.Write(node.data + " -> ");
            }
            Console.WriteLine();
        }
    }
}

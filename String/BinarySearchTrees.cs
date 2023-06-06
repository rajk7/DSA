using System;

class BinarySearchTrees
{
    public static void Main(String[] args)
    {

        //Binary Search Tree = A tree data structure, where each node is greater than it's left child,
        //		                         but less than it's right.

        //					   benefit: easy to locate a node when they are in this order						

        //					   time complexity: best case  O(log n)
        //									 worst case O(n)

        //					   space complexity: O(n)

        BinarySearchTree tree = new BinarySearchTree();

        tree.insert(new NodeTree(5));
        tree.insert(new NodeTree(1));
        tree.insert(new NodeTree(9));
        tree.insert(new NodeTree(2));
        tree.insert(new NodeTree(7));
        tree.insert(new NodeTree(3));
        tree.insert(new NodeTree(6));
        tree.insert(new NodeTree(4));
        tree.insert(new NodeTree(8));

        tree.remove(1);

        tree.display();

        Console.WriteLine(tree.search(0));
    }
}

public class BinarySearchTree
{

    NodeTree root;

    public void insert(NodeTree node)
    {

        root = insertHelper(root, node);
    }

    private NodeTree insertHelper(NodeTree root, NodeTree node)
    {

        int data = node.data;

        if (root == null)
        {
            root = node;
            return root;
        }
        else if (data < root.data)
        {
            root.left = insertHelper(root.left, node);
        }
        else
        {
            root.right = insertHelper(root.right, node);
        }

        return root;
    }

    public void display()
    {
        displayHelper(root);
    }

    private void displayHelper(NodeTree root)
    {

        if (root != null)
        {
            displayHelper(root.left);
            Console.WriteLine(root.data);
            displayHelper(root.right);
        }
    }

    public bool search(int data)
    {
        return searchHelper(root, data);
    }

    private bool searchHelper(NodeTree root, int data)
    {

        if (root == null)
        {
            return false;
        }
        else if (root.data == data)
        {
            return true;
        }
        else if (root.data > data)
        {
            return searchHelper(root.left, data);
        }
        else
        {
            return searchHelper(root.right, data);
        }
    }

    public void remove(int data)
    {

        if (search(data))
        {
            removeHelper(root, data);
        }
        else
        {
            Console.WriteLine(data + " could not be found");
        }
    }
    private NodeTree removeHelper(NodeTree root, int data)
    {

        if (root == null)
        {
            return root;
        }
        else if (data < root.data)
        {
            root.left = removeHelper(root.left, data);
        }
        else if (data > root.data)
        {
            root.right = removeHelper(root.right, data);
        }
        else
        { // node found
            if (root.left == null && root.right == null)
            {
                root = null;
            }
            else if (root.right != null)
            { //find a successor to replace this node
                root.data = successor(root);
                root.right = removeHelper(root.right, root.data);
            }
            else
            { //find a predecessor to replace this node
                root.data = predecessor(root);
                root.left = removeHelper(root.left, root.data);
            }
        }
        return root;
    }

    private int successor(NodeTree root)
    { //find least value below the right child of this root node
        root = root.right;
        while (root.left != null)
        {
            root = root.left;
        }
        return root.data;
    }

    private int predecessor(NodeTree root)
    {//find greatest value below the left child of this root node
        root = root.left;
        while (root.right != null)
        {
            root = root.right;
        }
        return root.data;
    }
}
public class NodeTree
{

    public int data;
    public NodeTree left;
    public NodeTree right;

    public NodeTree(int data)
    {
        this.data = data;
    }
}
Here is a simple console application in C# that determines if two binary trees are identical:

```C#
using System;

public class Node
{
    public int data;
    public Node left, right;
    public Node(int item)
    {
        data = item;
        left = right = null;
    }
}

public class BinaryTree
{
    public Node root;

    public bool IdenticalTrees(Node a, Node b)
    {
        if (a == null && b == null)
            return true;

        if (a != null && b != null)
            return (a.data == b.data && IdenticalTrees(a.left, b.left) && IdenticalTrees(a.right, b.right));

        return false;
    }

    public static void Main(string[] args)
    {
        BinaryTree tree = new BinaryTree();

        tree.root = new Node(1);
        Node root1 = tree.root;
        root1.left = new Node(2);
        root1.right = new Node(3);
        root1.left.left = new Node(4);
        root1.left.right = new Node(5);

        BinaryTree tree2 = new BinaryTree();

        tree2.root = new Node(1);
        Node root2 = tree2.root;
        root2.left = new Node(2);
        root2.right = new Node(3);
        root2.left.left = new Node(4);
        root2.left.right = new Node(5);

        if (tree.IdenticalTrees(root1, root2))
            Console.WriteLine("Both trees are identical.");
        else
            Console.WriteLine("Trees are not identical.");

        Console.ReadKey();
    }
}
```

This program creates two binary trees and checks if they are identical. If they are, it prints "Both trees are identical." If they are not, it prints "Trees are not identical."
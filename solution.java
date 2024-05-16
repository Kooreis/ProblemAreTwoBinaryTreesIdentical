Here is a Java console application that determines if two binary trees are identical:

```java
import java.util.Scanner;

class Node {
    int data;
    int height;
    Node left, right;

    Node(int d) {
        data = d;
        height = 1;
    }
}

class BinaryTree {
    Node root;

    boolean identicalTrees(Node a, Node b) {
        if (a == null && b == null)
            return true;

        if (a != null && b != null)
            return (a.data == b.data && identicalTrees(a.left, b.left) && identicalTrees(a.right, b.right));

        return false;
    }

    public static void main(String[] args) {
        BinaryTree tree1 = new BinaryTree();
        BinaryTree tree2 = new BinaryTree();

        tree1.root = new Node(1);
        tree1.root.left = new Node(2);
        tree1.root.right = new Node(3);
        tree1.root.left.left = new Node(4);
        tree1.root.left.right = new Node(5);

        tree2.root = new Node(1);
        tree2.root.left = new Node(2);
        tree2.root.right = new Node(3);
        tree2.root.left.left = new Node(4);
        tree2.root.left.right = new Node(5);

        if (tree1.identicalTrees(tree1.root, tree2.root))
            System.out.println("Both trees are identical");
        else
            System.out.println("Trees are not identical");

    }
}
```

This program creates two binary trees and checks if they are identical. If they are, it prints "Both trees are identical". If they are not, it prints "Trees are not identical".
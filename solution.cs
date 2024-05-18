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
}
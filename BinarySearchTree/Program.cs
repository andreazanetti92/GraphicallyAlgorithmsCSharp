// See https://aka.ms/new-console-template for more information

Console.WriteLine("Binary Search Tree");

// If left subtree of any node is not empty, the value of all nodes on the left subtree is less than the value of its root node
// If the right subtree of any node is not empty, the value of all nodes on the right subtree is greater than the value of its root node
// The left and right subtree of any node are also binary search trees

BinaryTree tree = new BinaryTree();

// Constructing a binary search tree
tree.Insert(tree.getRoot(), 60);
tree.Insert(tree.getRoot(), 40);
tree.Insert(tree.getRoot(), 20);
tree.Insert(tree.getRoot(), 10);
tree.Insert(tree.getRoot(), 30);
tree.Insert(tree.getRoot(), 50);
tree.Insert(tree.getRoot(), 80);
tree.Insert(tree.getRoot(), 70);
tree.Insert(tree.getRoot(), 90);

Console.WriteLine("In-Order Traversal binary search tree");
tree.InOrder(tree.getRoot());

Console.WriteLine("\nPre-Order Traversal binary search tree");
tree.PreOrder(tree.getRoot());

Console.WriteLine("\nPre-Order Traversal binary search tree");
tree.PostOrder(tree.getRoot());

Console.WriteLine("\n Min Value");
tree.MinValue(tree.getRoot());

Console.WriteLine("\n Max Value");
tree.MaxValue(tree.getRoot());

Console.WriteLine("\n Delete node 40");
tree.Remove(tree.getRoot(), 40);

Console.WriteLine("In-Order Traversal binary search tree");
tree.InOrder(tree.getRoot());

public class BinaryTree
{
    private Node root;
    public Node getRoot()
    {
        return root;
    }

    public Node Remove(Node node, int data)
    {
        if (node == null) return node;

        int compareValue = data - node.data;

        if (compareValue > 0) node.right = Remove(node.right, data);

        else if(compareValue < 0) node.left = Remove(node.left, data);

        else if(node.left != null && node.right != null)
        {
            node.data = MinValue(node.right).data;
            node.right = Remove(node.right, node.data);
        }
        else
        {
            node = (node.left != null) ? node.left : node.right;
        }

        return node;


    }

    // Minimun Value 
    public Node MinValue(Node node)
    {
        if (node == null || node.data == 0) return null;

        if (node.left == null) return node;

        return MinValue(node.left);
    }

    // Maximum Value
    public Node MaxValue(Node node)
    {
        if (node == null || node.data == 0) return null;

        if(node.right == null) return node;

        return node.right;
    }

    // Post-Order traversal binary
    public void PostOrder(Node root)
    {
        if (root == null) return;

        PostOrder(root.left);
        PostOrder(root.right);

        Console.Write(root.data + ", ");
    }

    // Pre-Order traversal binary
    public void PreOrder(Node root)
    {
        if (root == null) return;

        Console.Write(root.data + ", ");

        PreOrder(root.left); // Recursive traversing the left subtree
        PreOrder(root.right); // Recursive traversing the right subtree
    }

    // In-order traversal binary search tree
    public void InOrder(Node root)
    {
        if (root == null) return;

        InOrder(root.left); // Traversing the left subtree
        Console.Write(root.data + ",");
        InOrder(root.right); // Traversing the right subtree
    }

    public void Insert(Node node, int data)
    {
        if(root == null)
        {
            root = new Node(data, null, null);
            return;
        }

        int compareValue = data - node.data;

        // Recursive left subtree, continue to find the insertion position
        if(compareValue < 0)
        {
            if(node.left == null)
            {
                node.left = new Node(data, null, null);
            }
            else
            {
                Insert(node.left, data);
            }
        }
        // Recursive right subtree, continue to find the insertion position
        else if(compareValue > 0)
        {
            if (node.right == null)
            {
                node.right = new Node(data, null, null);
            }
            else
            {
                Insert(node.right, data);   
            }
        }
    }
}

public class Node
{
    public int data { get; set; }
    public Node left { get; set; }
    public Node right { get; set; }

    public Node(int data, Node left, Node right)
    {
        this.data = data;
        this.left = left;
        this.right = right;
    }
}

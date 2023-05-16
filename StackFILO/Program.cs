// See https://aka.ms/new-console-template for more information
Console.WriteLine("Stack FILO (First In Last Out)");

Stack stack = new Stack();
stack.Push("A");
stack.Push("B");
stack.Push("C");
stack.Push("D");

Console.WriteLine(stack.Size());
FlushThenPrint(stack);
Console.WriteLine("After Flush: " + stack.Size());

static void FlushThenPrint(Stack stack)
{
    Console.Write("Top ");
    Node node = null;
    while((node = stack.Pop()) != null)
    {
        Console.Write(node.data + " -> ");
    }

    Console.Write("End\n");
}

public class Stack
{
    private Node top;
    private int size;

    public void Push(string data)
    {
        if(top == null)
        {
            top = new Node(data);
        }
        else
        {
            Node node = new(data);
            node.next = top;
            top = node;
        }
        size++;
    }

    public Node Pop()
    {
        if(top == null)
        {
            return null;
        }
        Node p = top;
        top = top.next;
        p.next = null;
        size--;
        return p;
    }

    public int Size()
    {
        return size;
    }
}

public class Node
{
    public string data { get; set; }
    public Node next { get; set; }

    public Node(string data)
    {
        this.data = data;
    }
}

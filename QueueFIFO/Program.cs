// See https://aka.ms/new-console-template for more information

Console.WriteLine("Queue FIFO (First In First Out)");

Queue queue = new Queue();
queue.Offer("A");
queue.Offer("B");
queue.Offer("C");
queue.Offer("D");

Console.WriteLine(queue.Size());
FlushThenPrint(queue);
Console.WriteLine("After Flush -> " + queue.Size()); // 0


static void FlushThenPrint(Queue queue)
{
    Console.Write("Head ");
    Node node = null;
    while((node = queue.Poll()) != null)
    {
        Console.Write($"{node.data} <- ");
    }

    Console.Write("Tail\n");
}

public class Queue
{
    private Node head;
    private Node tail;
    private int size; // you could avoid to init the size

    public void Offer(string data)
    {
        if(head == null)
        {
            head = new Node(data);
            tail = head;
        }
        else
        {
            Node node = new Node(data);
            node.next = tail;
            tail.prev = node;
            tail = node;
        }
        size++;
    }

    public Node Poll()
    {
        Node p = head;
        if(p == null)
        {
            return null;
        }
        head = head.prev;
        p.next = null;
        p.prev = null;
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
    public Node prev { get; set; }

    public Node(string data)
    {
        this.data = data;
    }
}
// See https://aka.ms/new-console-template for more information
Console.WriteLine("One-Way Circular Linked List");

Init();
Insert(1, new Node("AB"));
Print();
Remove(1);
Print();


static void Init()
{
    OneWayCircularLinkedList.head = new("A");

    Node nodeB = new("B");
    OneWayCircularLinkedList.head.next = nodeB;

    Node nodeC = new("C");
    nodeB.next = nodeC;

    OneWayCircularLinkedList.tail = new("D");
    OneWayCircularLinkedList.tail.next = OneWayCircularLinkedList.head;
    nodeC.next = OneWayCircularLinkedList.tail;
}

static void Insert(int position, Node node)
{
    Node p = OneWayCircularLinkedList.head;
    int i = 0;
    
    // Move the node to the insert position
    while(p.next != null && i < position - 1)
    {
        p = p.next;
        i++;
    }

    node.next = p.next;
    p.next = node;
}

static void Remove(int position)
{
    Node p = OneWayCircularLinkedList.head;
    int i = 0;
    while(p.next != null && i < position - 1)
    {
        p = p.next;
        i++;
    }

    Node temp = p.next;
    p.next = p.next.next;
    temp.next = null;
    
}

static void Print()
{
    Node p = OneWayCircularLinkedList.head;
    do
    {
        Console.Write($"{p.data} -> ");
        p = p.next;
    } 
    while (p != OneWayCircularLinkedList.head);

    Console.WriteLine(p.data);
}

public static class OneWayCircularLinkedList
{
    public static Node head;
    public static Node tail;
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
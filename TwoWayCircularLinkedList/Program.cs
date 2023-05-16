// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic.FileIO;

Console.WriteLine("Two Way Circular Linked List");

Init();
Insert(1, new Node("AB"));
Print();

Delete(1);
Print();

static void Print()
{
    Node p = TwoWayCircularLinkedList.head;

    do
    {
        Console.Write($"{p.data} -> ");
        p = p.next;
    }
    while (p != TwoWayCircularLinkedList.head);

    Console.Write($"{p.data}\n");

    p = TwoWayCircularLinkedList.tail;
    do
    {
        Console.Write($"{p.data} -> ");
        p = p.prev;
    }while(p != TwoWayCircularLinkedList.tail);

    Console.Write($"{p.data}\n\n");
}

static void Delete(int position)
{
    Node p = TwoWayCircularLinkedList.head;
    int i = 0;

    while(p.next != null && i < position - 1)
    {
        p = p.next;
        i++;
    }

    Node temp = p.next;
    p.next = p.next.next;
    p.next.prev = p;

}

static void Insert(int position, Node node)
{
    Node p = TwoWayCircularLinkedList.head;
    int i = 0;

    while(p.next != null && i < position - 1)
    {
        p = p.next;
        i++;
    }

    node.next = p.next;
    p.next = node;
    node.prev = p;
    node.next.prev = node;
}

static void Init()
{
    TwoWayCircularLinkedList.head = new("A");

    Node nodeB = new("B");
    TwoWayCircularLinkedList.head.next = nodeB;
    nodeB.prev = TwoWayCircularLinkedList.head;

    Node nodeC = new("C");
    nodeC.prev = nodeB;
    nodeB.next = nodeC;

    Node nodeD = new("D");
    nodeD.prev = nodeC;
    nodeC.next = nodeD;

    TwoWayCircularLinkedList.tail = new("E");
    nodeD.next = TwoWayCircularLinkedList.tail;
    TwoWayCircularLinkedList.tail.prev = nodeD;
    TwoWayCircularLinkedList.tail.next = TwoWayCircularLinkedList.head;
    TwoWayCircularLinkedList.head.prev = TwoWayCircularLinkedList.tail;
}

public static class TwoWayCircularLinkedList
{
    public static Node head;
    public static Node tail;
}

public class Node
{
    public string data { get; set; }
    public Node prev { get; set; }
    public Node next { get; set; }

    public Node(string data)
    {
        this.data = data;
    }
}


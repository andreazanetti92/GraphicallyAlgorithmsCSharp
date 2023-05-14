// See https://aka.ms/new-console-template for more information
Console.WriteLine("Doubly Linked List");

Init();
Print(DoublyLinkedList.head);
Add(new Node("Walnut"));
//PrintBackward(DoublyLinkedList.tail);


static Node Init()
{
    // The first called head
    DoublyLinkedList.head = new Node("San Francisco");
    DoublyLinkedList.head.prev = null;

    Node? nodeOakland = new("Oakland");
    nodeOakland.prev = DoublyLinkedList.head;
    DoublyLinkedList.head.next = nodeOakland;

    Node? nodeBerkeley = new("Berkeley");
    nodeBerkeley.prev = nodeOakland;
    nodeOakland.next = nodeBerkeley;

    // The last node called tail
    DoublyLinkedList.tail = new Node("Fremont");
    DoublyLinkedList.tail.prev = nodeBerkeley;
    nodeBerkeley.next = DoublyLinkedList.tail;

    return DoublyLinkedList.head;
}

static void Add(Node node)
{
    DoublyLinkedList.tail.next = node;
    node.prev = DoublyLinkedList.tail;
    DoublyLinkedList.tail = node;

}

static void Print(Node node)
{
    Node p = node;
    Node end = null;
    while (p != null)
    {
        Console.Write($"{p.data} -> ");
        end = p;
        p = p.next;
    }

    Console.WriteLine("End");

    p = end;
    while(p != null)
    {
        Console.Write($"{p.data} -> ");
        p = p.prev;
    }

    Console.WriteLine("Start");
}

static void PrintBackward(Node node)
{
    Node p = node;
    while (p != null)
    {
        Console.Write($"{p.data} -> ");
        p = p.prev;
    }
    Console.WriteLine("End");
}

static class DoublyLinkedList
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
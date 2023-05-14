// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

Console.WriteLine("Unidirectional Linked List");

// Is a chained storage structure of a linear table, which is connected by a node.
// Each node consist of data and next pointer to the next node

Init();
Print(UnidirectionalLinkedList.head);


static Node Init()
{
    // The first called head
    UnidirectionalLinkedList.head = new Node("San Francisco", null);

    Node? nodeOakland = new("Oakland", null);
    UnidirectionalLinkedList.head.next = nodeOakland;

    Node? nodeBerkeley = new("Berkeley", null);
    nodeOakland.next = nodeBerkeley;

    // The last node called tail
    UnidirectionalLinkedList.tail = new Node("Fremont", null);
    nodeBerkeley.next = UnidirectionalLinkedList.tail;

    return UnidirectionalLinkedList.head;
}

static void Print(Node node)
{
    Node p = node;
    while (p != null)
    {
        Console.Write($"{p.data} -> ");
        p = p.next;
    }
    Console.WriteLine("End");
}

static class UnidirectionalLinkedList
{
    public static Node? head;
    public static Node? tail;
}

public class Node
{
    public string? data { get; set; }
    public Node? next { get; set; }
    
    public Node(string data, Node next)
    {
        this.data = data;
        this.next = next;
    }
}

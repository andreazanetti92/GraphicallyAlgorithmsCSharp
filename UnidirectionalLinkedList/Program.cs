// See https://aka.ms/new-console-template for more information

Console.WriteLine("Unidirectional Linked List");

// Is a chained storage structure of a linear table, which is connected by a node.
// Each node consist of data and next pointer to the next node

Init();

Insert(2, new Node("Palo Alto", null)); // insert at the given position
Add(new Node("Walnut", null)); // add at the end
Remove(1);

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

static void Add(Node node)
{
    UnidirectionalLinkedList.tail.next = node;
    UnidirectionalLinkedList.tail = node;
}

static void Insert(int index, Node node)
{
    Node p = UnidirectionalLinkedList.head;
    int i = 0;
    while(p.next != null && i < index - 1)
    {
        p = p.next;
        i++;
    }

    node.next = p.next;
    p.next = node;

}

static void Remove(int position)
{
    Node p = UnidirectionalLinkedList.head;
    int i = 0;
    while(p.next != null && i < position - 1)
    {
        p = p.next;
        i++;
    }

    Node temp = p.next;
    p.next = p.next.next;
    temp.next = null;

    //(p.next.next, p.next) = (p.next, null);
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

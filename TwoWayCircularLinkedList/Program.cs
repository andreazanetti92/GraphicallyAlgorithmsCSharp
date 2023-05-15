// See https://aka.ms/new-console-template for more information
Console.WriteLine("Two Way Circular Linked List");

Init();

static void Print()
{

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

public class TwoWayCircularLinkedList
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


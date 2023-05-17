// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hash Table");

// Hash Table
// Access by mapping key => values in the table
// Map the array to the Hash Table mapping rule key % 4 

HashTable table = new HashTable();
table.Put("Pete", "Game Developer");
table.Put("Andrew", "Game Designer & Developer");
Console.WriteLine("Pete => " + table.Get("Pete"));
Console.WriteLine("Andrew => " + table.Get("Andrew"));

public class HashTable
{
    public Node[] table;
    private int capacity = 16;
    private int size;

    public HashTable()
    {
        table = new Node[capacity];
    }

    public HashTable(int capacity)
    {
        table = new Node[capacity];
        size = 0;
        this.capacity = capacity;
    }

    private int HashCode(object key)
    {
        if(key is null) throw new ArgumentNullException(nameof(key));

        int num = 0;
        char[] chs = key.ToString().ToCharArray();
        for (int i = 0; i < chs.Length; i++)
        {
            num += (int)chs[i];
        }
        // Hash strategy is to take the square in the middle
        double avg = num * (Math.Pow(5, 0.5) - 1) / 2;
        double numeric = avg - Math.Floor(avg);
        return (int)Math.Floor(numeric * capacity);
    }

    public int Size()
    {
        return size;
    }

    public bool IsEmpty()
    {
        return size == 0 ? true : false;
    }

    public void Put(object key, object value)
    {
        int hash = HashCode(key);
        Node newNode = new(key, value, hash, null);
        Node node = table[hash];
        while(node is not null)
        {
            if (node.key.Equals(key))
            {
                node.value = value;
                return;
            }
            node = node.next;
        }
        newNode.next = table[hash];
        table[hash] = newNode;
        size++;
    }

    public object Get(object key)
    {
        if (key is null) throw new ArgumentNullException(nameof(key));

        int hash = HashCode(key);
        Node node = table[hash];
        while(node is not null)
        {
            if (node.key.Equals(key))
            {
                return node.value;
            }
            node = node.next;
        }

        throw new Exception("We cannot find the value for the given key");
    }
}

public class Node
{
    public object key;
    public object value;
    public int hash;
    public Node next;

    public Node(object key, object value, int hash, Node next)
    {
        this.key = key;
        this.value = value;
        this.hash = hash;
        this.next = next;
    }
}



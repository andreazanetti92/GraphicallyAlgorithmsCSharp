// See https://aka.ms/new-console-template for more information
Console.WriteLine("Undirected Graph: Breadth-First Search");

// The only differences with Depth-First Search is that Breadth use queue instead of stack

Graph graph = new Graph(5);
graph.AddVertex("A");
graph.AddVertex("B");
graph.AddVertex("C");
graph.AddVertex("D");
graph.AddVertex("E");

graph.AddEdge(0, 1);
graph.AddEdge(0, 2);
graph.AddEdge(0, 3);
graph.AddEdge(1, 2);
graph.AddEdge(1, 3);
graph.AddEdge(2, 3);
graph.AddEdge(3, 4);

// Two-Dimensional array treversal output vertex edge and adjacent array
PrintGraph(graph);
Console.WriteLine("Breadth-Search traversal output: ");
graph.BreadthFirstSearch();

static void PrintGraph(Graph graph)
{
    Console.WriteLine("Two-Dimensional array traversal vertex edge and adjacent array: ");
    for (int i = 0; i < graph.GetVertexes().Length; i++)
    {
        Console.Write(graph.GetVertexes()[i].data + " ");
    }

    Console.WriteLine();

    for (int i = 0; i < graph.GetAdjacencyMatrix().GetLength(0); i++)
    {
        Console.Write(graph.GetVertexes()[i].data + " ");

        for (int j = 0; j < graph.GetAdjacencyMatrix().GetLength(0); j++)
        {
            Console.Write(graph.GetAdjacencyMatrix()[i, j] + " ");
        }

        Console.WriteLine();
    }
}

public class Graph
{
    private int maxVertexSize; // Two-dimensional array size
    private int size; // Current vertex size
    private Vertex[] vertexes;
    private int[,] adjacencyMatrix;

    private Queue<Int32> queue; // Queue saves current vertexes // Queue FIFO (First In First Out) collection

    public Graph(int maxVertexSize)
    {
        this.maxVertexSize = maxVertexSize;
        vertexes = new Vertex[maxVertexSize];
        adjacencyMatrix = new int[maxVertexSize, maxVertexSize];
        queue = new Queue<Int32>();
    }

    public void AddVertex(string data)
    {
        Vertex vertex = new Vertex(data, false);
        vertexes[size] = vertex;
        size++;
    }

    // Add adjacent edges
    public void AddEdge(int from, int to)
    {
        // A -> B = B -> A
        adjacencyMatrix[from, to] = 1;
        adjacencyMatrix[to, from] = 1;
    }

    public void BreadthFirstSearch()
    {
        // Start searching from the first vertex
        Vertex firstVertex = vertexes[0];
        firstVertex.visited = true;
        Console.Write(firstVertex.data);
        queue.Enqueue(0);

        int col;
        while (queue.Count > 0)
        {
            int head = queue.Dequeue();

            // Get Adjacent vertex positions that have not been visited
            col = FindAdjacencyUnVisitedVertex(head);

            while (col != -1)
            {
                vertexes[col].visited = true;
                Console.Write(" -> " + vertexes[col].data);
                queue.Enqueue(col);
                col = FindAdjacencyUnVisitedVertex(head);
            }
        }
        Clear();
    }

    // Get adjacent vertex positions that have not been visited
    public int FindAdjacencyUnVisitedVertex(int row)
    {
        for (int col = 0; col < size; col++)
        {
            if (adjacencyMatrix[row, col] == 1 && !vertexes[col].visited)
            {
                return col;
            }
        }
        return -1;
    }

    public void Clear()
    {
        for (int i = 0; i < size; i++)
        {
            vertexes[i].visited = false;
        }
    }

    public int[,] GetAdjacencyMatrix()
    {
        return adjacencyMatrix;
    }

    public Vertex[] GetVertexes()
    {
        return vertexes;
    }


}

public class Vertex
{
    public string data;
    public bool visited;

    public Vertex(string data, bool visited)
    {
        this.data = data;
        this.visited = visited;
    }
}

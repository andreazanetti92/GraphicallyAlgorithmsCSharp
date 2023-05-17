// See https://aka.ms/new-console-template for more information
Console.WriteLine("Directed Graph: Topological Sorting");

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
Console.WriteLine("Topological-Search traversal output: ");
graph.TopologySort();

for (int i = 0; i < graph.GetTopologies().Length; i++)
{
    Console.Write(graph.GetTopologies()[i].data + " -> ");
}

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
    private Vertex[] topologies;

    public Graph(int maxVertexSize)
    {
        this.maxVertexSize = maxVertexSize;
        vertexes = new Vertex[maxVertexSize];
        adjacencyMatrix = new int[maxVertexSize, maxVertexSize];
        topologies = new Vertex[maxVertexSize];
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
        // A -> B != B -> A
        adjacencyMatrix[from, to] = 1;
    }

    public void TopologySort()
    {
        while (size > 0)
        {
            int noSuccessorVertex = GetNoSuccessorVertex();
            if (noSuccessorVertex == -1)
            {
                Console.WriteLine("There is ring in Graph");
                return;
            }
            topologies[size - 1] = vertexes[noSuccessorVertex]; // Copy the deleted node to the sorted array
            RemoveVertex(noSuccessorVertex); // Delete no successor
        }
    }

    public int GetNoSuccessorVertex()
    {
        bool existSuccessor = false;
        for (int row = 0; row < size; row++)
        {
            // for each vertex
            existSuccessor = false;
            // If the node has a fixed row, each column has a 1, indicating that the node has a successor, terminating the loop
            for (int col = 0; col < size; col++)
            {
                if (adjacencyMatrix[row, col] == 1)
                {
                    existSuccessor = true;
                    break;
                }
            }

            if (!existSuccessor)
            {
                // If the node has no successor, return its subscript
                return row;
            }
        }
        return -1;
    }

    public void RemoveVertex(int vertex)
    {
        if (vertex != size - 1)
        {
            // If the vertex is the last element, the end
            for (int i = vertex; i < size - 1; i++)
            {
                vertexes[i] = vertexes[i + 1]; // the vertexes are removed from the vertexes array
            }

            for (int row = vertex; row < size - 1; row++)
            {
                for (int col = 0; col < size - 1; col++)
                {
                    adjacencyMatrix[row, col] = adjacencyMatrix[row + 1, col]; // Move up a row
                }
            }


            for (int col = vertex; col < size - 1; col++)
            {
                for (int row = 0; row < size - 1; row++)
                {
                    adjacencyMatrix[row, col] = adjacencyMatrix[row, col + 1];  // Move left a row
                }
            }

        }
        size--;
    }

    public Vertex[] GetTopologies()
    {
        return topologies;
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
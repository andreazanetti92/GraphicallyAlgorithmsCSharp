// See https://aka.ms/new-console-template for more information

Console.WriteLine("Binary Heap Sort");

// The value of the non-terminal node in the binary tree in NOT greater then the values of its left and right child nodes
// Small top heap: Ki <= k2i and ki <= k2i + 1
// Big top heap: ki >= k2i and ki >= k2i + 1

// Parent node subscript = (i - 1) / 2
// Left subnode subscript = 2 * i + 1
// Right subnode subscript = 2 * i + 2

// Heap sorting process:
// 1. Build a Heap
// 2. After outputting the top element of the heap, adjust from top to bottom, compare the top with the root node of its left and right subtrees, and
// swap the smallest element to the top of the heap; then adjust continuously until the leaf nodes to get new heap.

HeapSortAlgo heapSort = new();
int[] scores = { 90, 10, 20, 80, 30, 70, 40, 60, 50 };

Console.WriteLine("Before building a heap: ");
foreach (var score in scores) Console.Write(score + ", ");

Console.WriteLine("");

Console.WriteLine("After building a heap: ");
heapSort.CreateHeap(scores);
foreach(var score in scores) Console.Write(score + ", ");

Console.WriteLine("");

Console.WriteLine("After sorting the heap: ");
heapSort.HeapSort();
foreach (var score in scores) Console.Write(score + ", ");

public class HeapSortAlgo
{
    private int[]? array;

    // Initialize the heap
    public void CreateHeap(int[] array)
    {
        this.array = array;

        // Build a heap, (array.Length - 1) / 2 scan half of the nodes with child nodes
        for(int i = (array.Length - 1) / 2; i >= 0; i--)
        {
            AdjustHeap(i, array.Length - 1);
        }
    }

    public void AdjustHeap(int currentIndex, int maxLength)
    {
        if (array is null) return;

        int noLeafValue = array[currentIndex]; // Current non-leaf node

        // 2 * currentIndex + 1 Current left subtree subscript
        for (int j = 2 * currentIndex + 1; j < maxLength; j = currentIndex * 2 + 1)
        {
            if(j < maxLength && array[j] < array[j + 1])
            {
                j++; // j Large subscript
            }

            if(noLeafValue >= array[j])
            {
                break;
            }

            array[currentIndex] = array[j]; // Move up to the parent node
            currentIndex = j;
        }

        array[currentIndex] = noLeafValue; // To put in the position
    }

    public void HeapSort()
    {
        if (array is null) return;

        for (int i = array.Length - 1; i > 0 ; i--)
        {
            (array[0], array[i]) = (array[i], array[0]);
            AdjustHeap(0, i - 1);
        }
    }
}


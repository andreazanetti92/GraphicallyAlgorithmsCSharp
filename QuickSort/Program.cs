// See https://aka.ms/new-console-template for more information

Console.WriteLine("Quick Sort Algorithm");

int[] scores = { 90, 60, 50, 80, 70, 100 };

QuickSortAlgo.QuickSort(scores);

foreach (int score in scores) Console.WriteLine(score);


public class QuickSortAlgo
{
    public static void QuickSort(int[] array)
    {
        if(array.Length > 0)
        {
            QuickSort(array, 0, array.Length - 1);
        }
    }

    private static void QuickSort(int[] array, int low, int high)
    {
        if(low > high)
        {
            return;
        }

        int i = low;
        int j = high;
        int threshold = array[low];

        // Alternately scanned from both ends of the list
        while (i < j)
        {
            // Find the first position less than threshold from right to left
            while(i < j && array[j] > threshold)
                j--;
            
            // Replace the low with a smaller num than the threshold
            if(i < j)
                array[i++] = array[j];

            // Find the first position greater than threshold from left to right
            while(i < j && array[i] <= threshold)
                i++;

            // Replace the high with a number larger than the threshold
            if(i < j)
                array[j--] = array[i];
        }

        array[i] = threshold;
        QuickSort(array, low, i - 1); // Left QuickSort
        QuickSort(array, i+ 1, high); // Right QuickSort
    }
}


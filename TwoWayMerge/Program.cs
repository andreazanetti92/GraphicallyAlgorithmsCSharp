// See https://aka.ms/new-console-template for more information
Console.WriteLine("Two-Way Merge Algorithm");

int[] scores = { 50, 65, 99, 87, 74, 63, 76, 100, 92 };

//foreach (int score in scores) Console.WriteLine(score);

MergeSortAlgo.MergeSort(scores);

foreach(int score in scores) Console.WriteLine(score);

public static class MergeSortAlgo
{
    public static void MergeSort(int[] array)
    {
        MergeSort(array, new int[array.Length], 0, array.Length - 1);
    }
     
    private static void MergeSort(int[] array, int[] temp, int left, int right)
    {
        if(left < right)
        {
            int center = (left + right) / 2;
            MergeSort(array, temp, left, center); // Left merge sort
            MergeSort(array, temp, center + 1, right); // Right merge sort
            Merge(array, temp, left, center + 1, right); // Merge two ordered arrays
        }
    }

    /**
    Combine two ordered list into an ordered list
    temp: Temporary array
    left: Start the subscript on the left
    right: Start the subscript on the right
    rightEndIndex: End subscript on the right
     */
    private static void Merge(int[] array, int[] temp, int left, int right, int rightEndIndex)
    {
        int leftEndIndex = right - 1; // End subscript on the left
        int tempIndex = left; // Starting from the left count
        int eleNum = rightEndIndex - left + 1;

        while (left <= leftEndIndex && right <= rightEndIndex)
        {
            if (array[left] <= array[right])
                temp[tempIndex++] = array[left++];
            else
                temp[tempIndex++] = array[right++];
        }

        while(left <= leftEndIndex) // If there is element on the left
        {
            temp[tempIndex++] = array[left++];
        }
        
        while(right <= rightEndIndex) // If there is element on the right
        {
            temp[tempIndex++] = array[right++];
        }

        // Copy temp to array
        for(int i = 0; i < eleNum; i++)
        {
            array[rightEndIndex] = temp[rightEndIndex];
            rightEndIndex--;
        }
    }

}


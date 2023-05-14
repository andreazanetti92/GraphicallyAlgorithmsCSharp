// See https://aka.ms/new-console-template for more information
Console.WriteLine("Shell Sorting");

// Shell sort is an highly efficent sorting algorithm based on insert sorting algorithm
// This algorithm avoids large shifts, if the smaller value is to the far right and has to be moved to the far left

// The array is grouped according to a certain increment of subscripts, and the insertion of each group is sorted.
// As the increment decrease gradually until the increment is 1, the whole data is grouped and sorted.

// Sorting from small to large
int[] scores = { 33, 55, 20, 34, 82, 48, 95, 67, 62, 95, 88, 79, 72, 13, 9, 3, 2 };

ShellSort(scores);

foreach (int score in scores) Console.WriteLine(score);

static void ShellSort(int[] original)
{
    for(int gap = original.Length / 2; gap > 0; gap /= 2)
    {
        for(int i = 0; i < original.Length; i++)
        {
            int j = i;
            while(j - gap >= 0 && original[j] < original[j - gap])
            {
                Swap(original, j, j - gap);
                j -= gap;
            }
        }
    }
}

static void Swap(int[] original, int i, int j)
{
    original[i] = original[i] + original[j];
    original[j] = original[i] - original[j];
    original[i] = original[i] - original[j];
}


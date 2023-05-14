// See https://aka.ms/new-console-template for more information
Console.WriteLine("Dichotomy Binary Search");

// This Algorithm is of type Divied and Conquer
// It's find the index position of the given value
// At each step select 2 distinct alternatives

// 1. Init the lowest index = 0 and highest index to lengtht - 1
// 2. Find the searchValue of the middle index mid = (low + high)/2 -> array[mid]
// 3. Compare the searchValue to array[mid]
// // if the scores[mid] == searchValue -> print the current index
// // // if scores[mid] > searchValue -> that searchValue will be found between low and mid - 1
// Repeat the step 3 until searchValue is found OR low >= high

int[] scores = { 30, 40, 50, 60, 70, 80, 90 };

int searchValue = 50;
int position = DichotomyBinarySearch(scores, searchValue);

Console.WriteLine(scores[2]);

Console.WriteLine($"{searchValue} found at {position}");

static int DichotomyBinarySearch(int[] original,  int searchValue)
{
    int low  = 0;
    int high = original.Length - 1;

    while (low <= high)
    {
        int mid = (low + high) / 2;
        if (original[mid] == searchValue) return mid;
        else if (original[mid] < searchValue) low = mid + 1;
        else if (original[mid] > searchValue) high = mid - 1;
    }

    return -1;
    
}





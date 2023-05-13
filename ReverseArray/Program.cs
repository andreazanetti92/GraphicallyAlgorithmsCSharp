// See https://aka.ms/new-console-template for more information
Console.WriteLine("Reverse Array");

// Algorithm idea
// Initial i = 0 and then swap the element array[i] with the last element array[length - i - 1]
// Repeat until index == length / 2

int[] scores = { 33, 55, 20, 34, 82, 48, 95, 67, 62, 95, 88, 79, 72, 13, 9, 3, 2 };

Reverse(scores);

foreach (int score in scores) Console.WriteLine(score);

static void Reverse(int[] original)
{
    int length = original.Length;
    int middle = length / 2;

    for (int i = 0; i <= middle; i++)
    {
        (original[i], original[length - i - 1]) = (original[length - i - 1], original[i]);
    }
}

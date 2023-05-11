// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("SelectSort");

int[] scores = { 33, 56, 20, 34, 82, 48, 95, 67, 62, 95, 88, 79, 72, 13, 9, 3, 6 };

Sort(scores);
foreach (int score in scores) Console.WriteLine(score);


static void Sort(int[] arrays)
{
    int len = arrays.Length - 1;
    int minIndex;

    for (var i = 0; i < len; i++)
    {
        minIndex = i;
        int minValue = arrays[minIndex];
        for (var j = i; j < len; j++) 
        { 
            if(minValue > arrays[j + 1])
            {
                minValue = arrays[j + 1];
                minIndex = j + 1;
            }
        }
        if(i != minIndex)
        {
            int temp = arrays[i];
            arrays[i] = arrays[minIndex];
            arrays[minIndex] = temp;
        }
    }
}
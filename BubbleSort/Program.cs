// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bubble Sorting Algorithm");

int[] scores = { 33, 56, 20, 34, 82, 48, 95, 67, 62, 95, 88, 79, 72, 13, 9, 3, 6 };

Console.WriteLine("Start sorting ...");
sort(scores);

Console.WriteLine("Sorted array: ");

foreach (int score in scores)
    Console.WriteLine(score);

static void sort(int[] arrays)
{

    for (int i = 0; i < arrays.Length; i++)
    {
        bool isSwap = false;
        for (int j = 0; j < arrays.Length - 1 ; j++)
        {
            if (arrays[j] > arrays[j + 1])
            {
                // CLASSIC WAY
                //var temp = arrays[j];
                //arrays[j] = arrays[j + 1];
                //arrays[j + 1] = temp;

                // SWAPPING USING TUPLE
                (arrays[j + 1], arrays[j]) = (arrays[j], arrays[j + 1]);
                
                isSwap = true;
            }
        }

        if (!isSwap)
        {
            break;
        }
    }

}
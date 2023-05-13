// See https://aka.ms/new-console-template for more information
Console.WriteLine("Insert Sorting Algorithm");

int[] scores = { 80, 70, 60, 50, 95 };

insertSorting(scores);

foreach (int score in scores) Console.WriteLine(score);

static void insertSorting(int[] original)
{
    for (int i = 0; i < original.Length; i++)
    {
        int insertElement = original[i];
        int insertPosition = i;

        for (int j = insertPosition - 1; j >=0; j--) 
        {
            if(insertElement < original[j])
            {
                original[j + 1] = original[j];
                insertPosition--;
            }
        }

        original[insertPosition] = insertElement;
    }
}

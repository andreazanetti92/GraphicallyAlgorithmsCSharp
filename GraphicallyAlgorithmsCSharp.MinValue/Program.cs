// See https://aka.ms/new-console-template for more information
Console.WriteLine("Searching min value into an array of int");

int[] scores = { 33, 56, 20, 34, 82, 48, 95, 67, 62, 95, 88, 79, 72, 13, 9, 3, 6 };

Console.WriteLine("Searching for min value...");
int result = MinValue(scores);
Console.WriteLine(result.ToString());

static int MinValue(int[] arrays)
{
    int minIndex = 0;
	for (int j = 1; j < arrays.Length; j++)
	{
		if (arrays[j] < arrays[minIndex]) 
		{ 
			minIndex = j; 
		}
	}
	return arrays[minIndex];
}
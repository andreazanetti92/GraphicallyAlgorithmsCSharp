// See https://aka.ms/new-console-template for more information
Console.WriteLine("Linear Table Search");

int[] scores = { 33, 55, 20, 34, 82, 48, 95, 67, 62, 95, 88, 79, 72, 13, 9, 3, 2 };

Console.WriteLine("Enter a number to search: ");

int value = Convert.ToInt32(Console.ReadLine());

bool isSearch = false;

for (int i = 0; i < scores.Length; i++)
{
    if (scores[i] == value)
    {
        isSearch = true;
        Console.WriteLine($"Value {value} found at index {i}");
    }
}

if (!isSearch) Console.WriteLine("The given value is not found in the array");

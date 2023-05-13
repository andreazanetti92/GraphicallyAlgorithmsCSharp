// See https://aka.ms/new-console-template for more information
Console.WriteLine("Linear Table Delete");

// 1. Create a temp array less longer than original by one
// 2. Copy the data before given index to the beginning of temp array
// 3. Copy the data after given index to the end of temp array
// 4. Assign the temp array to original
//

int[] scores = { 33, 55, 20, 34, 82, 48, 95, 67, 62, 95, 88, 79, 72, 13, 9, 3, 2 };

Console.WriteLine("Enter the index where delete the element");

int index = Convert.ToInt32(Console.ReadLine());

int[] temp = new int[scores.Length - 1];
for (int i = 0; i < scores.Length; i++)
{
    if(i<index) temp[i] = scores[i];
    if(i > index) temp[i - 1] = scores[i];
}

scores = temp;

foreach (int score in scores) Console.WriteLine(score);


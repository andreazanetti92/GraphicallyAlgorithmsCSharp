
// Add an int to the end of an array
Console.WriteLine("Linear Table Append");


// 1. Create a temp array larger than the original array
// 2. Copy each value from the original array to the temp array
// 3. Assign the int to add at the last index of the array
// 4. Finally assign the temp array's pointer to the original array
// 


int[] scores = { 33, 56, 20, 34, 82, 48, 95, 67, 62, 95, 88, 79, 72, 13, 9, 3, 2 };

// Extension Method
int[] scoresAdded = scores.AddValue(105);

foreach (int score in scoresAdded)
    Console.WriteLine(score);

// Funtion Way
//int[] newScore = Add(scores, 99);

//foreach (int score in newScore)
//	Console.WriteLine(score);

// One Way
//int[] tempArr = new int[scores.Length + 1];

//for (int i = 0; i < scores.Length; i++)
//    tempArr[i] = scores[i];

//tempArr[scores.Length] = 75;

//scores = tempArr;

//foreach (int score in scores)
//    Console.WriteLine(score);
// End One Way

// Function Way
//static int[] Add(int[] original, int value)
//{
//    int[] tempArr = new int[original.Length + 1];

//	for (int i = 0; i < original.Length; i++)
//		tempArr[i] = original[i];

//	tempArr[original.Length] = value;

//	return tempArr;
//}

// Extension Method
public static class MyArrayExtension
{
    public static int[] AddValue(this int[] original, int value)
    {
        int[] tempArr = new int[original.Length + 1];

        for (int i = 0; i < original.Length; i++)
            tempArr[i] = original[i];

        tempArr[original.Length] = value;

        return tempArr;
    }
}



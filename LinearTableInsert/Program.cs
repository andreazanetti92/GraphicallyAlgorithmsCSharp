Console.WriteLine("Linear Table Insert");

// Insert an int at any index into an one-dimensional array

// 1. First create a tempArray larger the the original one
// 2. Copy each value of the previous value of the scores array from the beginning to the insertion position to tempArray
// 3. Move the scores array from the insertion position to each value of the last element and move it back to tempArray
// 4. Then insert the int to the index of the tempArray
// 5. Finally assign the tempArray pointer reference to the scores
//

int[] scores = { 33, 55, 20, 34, 82, 48, 95, 67, 62, 95, 88, 79, 72, 13, 9, 3, 2 };

//Funtion way
scores = Insert(scores, 44, 1);

foreach (int score in scores)
    Console.WriteLine(score);

// Function way
static int[] Insert(int[] original, int value, int index)
{
    int[] temp = new int[original.Length + 1];
    for (int i = 0; i < original.Length; i++)
    {
        if (i < index)
            temp[i] = original[i];
        else
            temp[i + 1] = original[i];
    }

    temp[index] = value;
    return temp;
}

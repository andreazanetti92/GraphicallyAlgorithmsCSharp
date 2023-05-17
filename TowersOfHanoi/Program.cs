// See https://aka.ms/new-console-template for more information
Console.WriteLine("Towers of Hanoi");

// Algorithm
// 1. If there is only 1 disc, move it directly to C (A -> C)
// 2. When there are 2 dics, use B as an auxiliary (A -> B, A -> C, B -> C)
// 3. If there are more than 2 disc, use B as an auxiliary (A -> B, A -> C, B -> C) and continue to recursive process

// 4. If there is only 1 disc, move it directly to C (A -> C)

Console.WriteLine("Please enter the num of disc: ");
int n = Convert.ToInt32(Console.ReadLine());
Hanoi(n, 'A', 'B', 'C');


static void Hanoi(int n, char a, char b, char c)
{
    if(n == 1)
    {
        Console.WriteLine($"Move {n} {a} to {c} ");
    }
    else
    {
        Hanoi(n - 1, a, c, b);
        Console.WriteLine($"Move {n} from {a} to {c}");
        Hanoi(n - 1, b, a, c);
    }
}
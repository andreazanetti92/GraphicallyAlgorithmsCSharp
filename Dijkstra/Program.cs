// See https://aka.ms/new-console-template for more information
Console.WriteLine("Dijkstra");

char[] flags = { 'R', 'B', 'W', 'B', 'R', 'W' };

int b = 0, w = 0, r = flags.Length - 1;

int count = 0;

while(w <= r)
{
    if (flags[w] == 'W') w++;
    else if (flags[w] == 'B')
    {
        (flags[w], flags[b]) = (flags[b], flags[w]);
        w++;
        b++;
        count++;
    }
    else if (flags[w] == 'R')
    {
        (flags[w], flags[r]) = (flags[r], flags[w]);
        w++;
        r--;
        count++;
    }
}

foreach (var c in flags) Console.Write(c + " | ");

Console.WriteLine($"\nTotal exchange {count}");
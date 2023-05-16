// See https://aka.ms/new-console-template for more information
Console.WriteLine("Recursive Algorihtm");

Console.WriteLine(factorial(10).ToString());

static long factorial(int n)
{
    if(n == 1)
    {
        return 1;
    }
    else
    {
        return factorial(n - 1) * n;
    }
}

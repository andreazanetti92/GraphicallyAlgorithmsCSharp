// See https://aka.ms/new-console-template for more information
Console.WriteLine("Finbonacci");

Console.WriteLine("Please enter the number of month: ");
int n = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= n; i++)
{
    Console.WriteLine(i + " month: " + Finbonacci(i));
}

static int Finbonacci(int n)
{
    if(n == 1 || n == 2)
    {
        return 1;
    }
    else
    {
        return Finbonacci(n - 1) + Finbonacci(n - 2);
    }
}
// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Mouse Walking Maze");

// Mouse Walking Maze is a basic type of recursive solution. We use 2 to represent the WALL in a 2-dimensional array, and use 1 to represent the path
// of the mouse, and try to find the path the entrance to exit.

// Solution:
// The mouse move in 4 directions: up, down, left and right. If hit the wall go back and select the next forward direction, so test the 4 directios
// in the array until the mouse reach the exit.
Console.WriteLine("Maze: \n");

for (int i = 0; i < 7; i++)
{
    for (int j = 0; j < 7; j++)
    {
        if (MouseWalkingMaze.maze[i, j] == 0) Console.Write("#");
        else Console.Write("* ");
    }
    Console.Write("");
}

if (MouseWalkingMaze.Visit(MouseWalkingMaze.startI, MouseWalkingMaze.startJ) == 0) Console.Write("No Exit Found");
else
{
    Console.WriteLine("Maze Path: ");
    for (int i = 0; i < 7; i++)
    {
        for (int j = 0; j < 7; j++)
        {
            if (MouseWalkingMaze.maze[i, j] == 2) Console.Write("#");
            else if (MouseWalkingMaze.maze[i, j] == 1) Console.Write("- ");
            else Console.Write("* ");
        }
        Console.WriteLine("");
    }
}

static class MouseWalkingMaze
{
    public static int[,] maze =
    {
        { 2, 2, 2, 2, 2, 2, 2 },
        { 2, 0, 0, 0, 0, 0, 2 },
        { 2, 2, 2, 0, 2, 0, 2 },
        { 2, 0, 2, 0, 0, 0, 2 },
        { 2, 2, 0, 2, 0, 2, 2 },
        { 2, 0, 0, 0, 0, 0, 2 },
        { 2, 2, 2, 2, 2, 2, 2 },
    };

    public static int startI = 1;
    public static int startJ = 1;
    public static int endI = 5;
    public static int endJ = 5;
    public static int success = 0;

    // The mouse moves in 4 directions: up, down, left and right. If hit the wall go back and select the next forward direction
    public static int Visit(int i, int j)
    {
        maze[i, j] = 1;
        
        if (i == endI && j == endJ) success = 1;
        if (success != 1 && maze[i, j + 1] == 0) Visit(i, j + 1);
        if (success != 1 && maze[i + 1, j] == 0) Visit(i + 1, j);
        if (success != 1 && maze[i, j - 1] == 0) Visit(i, j - 1);
        if (success != 1 && maze[i - 1, j] == 0) Visit(i - 1, j);
        if (success != 1) maze[i, j] = 0; 
            
        return success;
    }
}

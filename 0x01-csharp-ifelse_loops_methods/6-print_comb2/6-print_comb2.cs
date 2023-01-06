using System;

class Program
{
public static void Main(string[] args)
{
for (int i = 0; i <= 9; i++)
{
for (int j = 0; j <= 9; j++)
{
if (i == j)
{
continue;
}
Console.Write("{0}, {1}", i, j);
Console.WriteLine();
}
}
}
}

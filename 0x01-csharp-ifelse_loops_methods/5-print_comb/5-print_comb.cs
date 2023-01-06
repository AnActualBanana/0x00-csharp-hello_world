using System;

class Program
{
public static void Main(string[] args)
{
for (int i = 0; i <= 99; i++)
{
if (i == 99)
{
Console.WriteLine("{0:D2}", i);
}
else
{
Console.Write("{0:D2}, ", i);
}
}
}
}

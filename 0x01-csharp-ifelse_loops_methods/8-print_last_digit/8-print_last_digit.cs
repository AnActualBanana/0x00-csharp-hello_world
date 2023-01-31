using System;

class Number
{
public static int PrintLastDigit(int number)
{
int lastDigit = number % 10;
Console.WriteLine(lastDigit);
return lastDigit;
}
}

public static void Main(string[] args)
{
Number.PrintLastDigit(9876);
}

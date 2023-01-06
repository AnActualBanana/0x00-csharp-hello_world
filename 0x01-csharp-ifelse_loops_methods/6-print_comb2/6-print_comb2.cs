using System;

class Program
{
    static void Main(string[] args)
    {
        int j = 0;
        for (int i = 0; i < 9; i++)
        {
            for (int x = i + 1; x < 10; x++)
            {
                if (j == 1)
                {
                    Console.Write(", ");
                }
                j = 1;
                Console.Write("{0}{1}", i, x);
            }
        }
        Console.WriteLine();
    }
}

using System;

class Fur
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char a = '*';
        char d = '.';
        for (int i = 1; i < n; i++)
        {
            for (int j = 0; j < (2 * n - 3); j++)
            {
                if ((j > ((2 * n - 3) / 2) - i) && (j <= (2 * n - 3) - (n - i)))
                {
                    Console.Write(a);
                }
                else
                {
                    Console.Write(d);
                }
            } Console.WriteLine();
            if (i == n - 1)
            {
                for (int k = 0; k < (2 * n - 3); k++)
                {
                    if (k == (2 * n - 3) / 2)
                    {
                        Console.Write(a);
                    }
                    else
                    {
                        Console.Write(d);
                    }
                }
            }
        }
    }
}


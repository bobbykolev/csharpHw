using System;
using System.Numerics;

class HowManyZerosAfterNfact
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int sum = 0;
        BigInteger facN = 1;
        for (int i = 1; i <= N; i++)
        {
            facN *= i;
        }

        while (facN % 10 == 0)
        {
            facN = facN/10;
            sum++;
        }
        Console.WriteLine(sum);
    }
}

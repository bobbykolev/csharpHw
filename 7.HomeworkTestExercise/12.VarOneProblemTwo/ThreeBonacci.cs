using System;
using System.Numerics;

class ThreeBonacci
{
    static void Main()
    {
        BigInteger first = BigInteger.Parse(Console.ReadLine());
        BigInteger second = BigInteger.Parse(Console.ReadLine());
        BigInteger third = BigInteger.Parse(Console.ReadLine());
        BigInteger n = BigInteger.Parse(Console.ReadLine());

        BigInteger fourt;

        for (int i = 0; i < n-3; i++)
        {
            fourt = first + second + third;
            first = second;
            second = third;
            third = fourt;
        }
        Console.WriteLine(third);
    }
}

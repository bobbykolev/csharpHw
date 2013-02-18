using System;

class CalcFactoriel
{
    static void Main()
    {
        Console.WriteLine("Type N:");
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine("Type K:");
        int K = int.Parse(Console.ReadLine());

        double product = 1;

        int helper = (K - N);

        for (int i = 1; i <= helper; i++)
        {
            product *= (K + i);
        }
        double result = 1 / product;
        Console.WriteLine("{0}!/{1}! = {2:0.0000}", N, K, result);
    }
}

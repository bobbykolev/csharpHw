using System;

class SandGlass
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());


        for (int i = 0; i < N / 2 + 1; i++)
        {
            Console.Write(new string('.', i));
            Console.Write(new String('*', N - 2 * i));
            Console.Write(new String('.', i));
            Console.WriteLine();
        }
        for (int j = 0; j < (N / 2); j++)
        {
            Console.Write(new string('.', ((N / 2) - 1) - (2 * j / 2)));
            Console.Write(new String('*', 2 * j + 3));
            Console.Write(new String('.', ((N / 2) - 1) - (2 * j / 2)));
            Console.WriteLine();
        }
    }
}

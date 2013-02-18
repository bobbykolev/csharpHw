using System;

class ReadNandPrintMatrix
{
    static void Main()
    {
        byte N = byte.Parse(Console.ReadLine());
        
        for (int i = 0; i < N; i++)
        {
            for (int m = 1; m <= N; m++)
            {
                Console.Write(" " + (m + i) + " ");
            }
            Console.WriteLine();
        }
    }
}

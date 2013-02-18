using System;

class ForestRoad        //100/100 - BGCoder
{

    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        char asterix = '*';
        char dot = '.';



        for (int col = 1; col <= 2 * N /2 ; col++)
        {

            for (int row = 1; row <= N; row++)
            {

                if (row == col)
                {
                    Console.Write(asterix);
                }
                else
                {

                    Console.Write(dot);
                }
            }
            Console.WriteLine();
        }
        for (int col = N+1; col <= 2 * N-1 ; col++)
        {

            for (int row = N; row >= 1; row--)
            {

                if (row+N-1 == col)
                {
                    Console.Write(asterix);
                }
                else
                {

                    Console.Write(dot);
                }
            }
            Console.WriteLine();
        }
    }
}

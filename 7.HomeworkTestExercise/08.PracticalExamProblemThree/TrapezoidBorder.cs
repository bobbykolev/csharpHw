using System;

    class TrapezoidBorder //100/100 - BGCoder
    {
        static void Main()
        {
            byte N = byte.Parse(Console.ReadLine());
            char asterisk = '*';
            char dot = '.';
            for (int i = 0; i < (N+1); i++)
            {
                for (int j = 0; j < 2*N; j++)
                {
                    if (i == 0 && j < N)
                    {
                        Console.Write(dot);
                    }
                    if (i == 0 && j > N)
                    {
                        Console.Write(asterisk);
                    }
                    if (j == (2 * N) - 1 && i!= 0 && i!=N)
                    {
                        Console.Write(asterisk);
                    }
                    if (i == N)
                    {
                        Console.Write(asterisk);
                    }
                    if (j==N-i && j!=0)
                    {
                        Console.Write(asterisk);
                    }
                    else  if (i != 0 && i!=N && j!=(2*N-1))
                    {
                        Console.Write(dot);
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }

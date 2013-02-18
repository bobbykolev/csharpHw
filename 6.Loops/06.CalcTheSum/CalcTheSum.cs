using System;

    class CalcTheSum
    {
        static void Main()
        {
            Console.WriteLine("Type number N and press ENTER:");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Type number X and press ENTER:");
            int X = int.Parse(Console.ReadLine());
            decimal dividend = 1m;
            decimal divider = 1m;
            decimal sum = 1m;

                for (int j = 1; j <= N; j++)
                {
                        dividend *= j;
                        divider *= X;
                        sum = sum + (dividend / divider);
                }
                Console.WriteLine("The Sum \"S\" = {0}", sum);
        }
    }

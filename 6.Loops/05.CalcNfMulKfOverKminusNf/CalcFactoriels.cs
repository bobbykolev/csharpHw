using System;

    class CalcFactoriels
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type N and K separated by ENTER:");
            ulong N =  ulong.Parse(Console.ReadLine());
            ulong K =  ulong.Parse(Console.ReadLine());

            ulong product = 1L;
            ulong product2 = 1L;
            ulong helper = K - N;

            for (ulong i = 1 ; i <= N ; i++)
            {
                product = i * i * product;
            } 
            for (ulong j = 1; j <= helper; j++)
            {
                product = product * (N + j);
            }
            for (ulong k = 1; k <= helper; k++)
            {
                product2 = product2 * k;
            }
            decimal result = product/product2;
            Console.WriteLine("{1}!*{0}!/({0}-{1})! = {2}", K, N, result);
        }
    }

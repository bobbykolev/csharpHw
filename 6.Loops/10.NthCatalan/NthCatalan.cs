using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class NthCatalan
    {
        static void Main()
        {
            Console.WriteLine("Type a number \"N\" (N>0) to see the Nth Catalan number: ");
            int N = 10;
            decimal dividend = 1m;
            decimal dividerOne = 1m;
            decimal dividerTwo = 1m;
            decimal nC = 1m;

            for (int i = 1; i <= (2*N); i++)
            {
                dividend *= i;
            }
            for (int j = 1; j <= (1+N); j++)
            {
                dividerOne *= j;
            }
            for (int k = 1; k <= N; k++)
			{
			 dividerTwo *= k;
			}
            nC = dividend / (dividerOne * dividerTwo);
            Console.WriteLine(nC);
        }
    }

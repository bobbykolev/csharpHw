using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class A_PrintMultiArray
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] arr = new int[n, n];
        int m = 0;

        for (int i = 1; i <= n; i++)
        {
            for (int j = i, k = 0; j <= n * n; j += n, k++)
            {
                arr[i - 1, k] = j;
            }
        }
        foreach (var item in arr)
        {
            Console.Write(item+"  ");
            m++;
            if (m==n)
            {
                Console.WriteLine();
                m = 0;
            }
        }
    }
}

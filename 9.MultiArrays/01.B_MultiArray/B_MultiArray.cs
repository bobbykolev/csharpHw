using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class B_MultiArray
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] arr = new int[n, n];
            int m = 0;
            int J = 0;

            for (int i = 0; i < n; i++)
            {
                if (i%2==0)
                {
                    for (int j = 0; j < n; j++)
                    {
                        arr[j, i] = j+1+(i*n);
                        J = j + 1 + (i * n);
                    }
                }
                else
                {
                    for (int L = n-1; L >=0 ; L--)
                    {
                        arr[L, i] = ++J;
                    }
                }
                
            }
                
            foreach (var item in arr)
            {
                Console.Write(item + "  ");
                m++;
                if (m == n)
                {
                    Console.WriteLine();
                    m = 0;
                }
            }
        }
    }

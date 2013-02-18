using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class C_MultiArray
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] arr = new int[n, n];
        int count = 2;
        int m = 0;
        //bottom left corner
        arr[n - 1, 0] = 1;
        //first column
        for (int i = 0; i < 1; i++)
        {
            for (int k = n - i - 2; k >= 0; k--)
            {
                arr[k, i] = count;
                count += n - k;
            }
        }
        count = 0;
        //rest of bottom left half
        for (int c = 1; c < n; c++)
        {
            for (int f = n - 1; f > 0; f--)
            {
                if (f >= c)
                {
                    arr[f, c] = arr[f - 1, c - 1] + 1;
                }

            }
        }
        
        //upper right half
        for (int d = n - 1; d >= 0; d--)
        {
            for (int g = n-2; g >=0; g--)
            {
                if (g<d)
                {
                    arr[g, d] = arr[g + 1, d] + (n - d+g);
                }
                    
            }
        }


        //print
        foreach (var item in arr)
        {
            Console.Write("{0,-4}",item + "  ");
            m++;
            if (m == n)
            {
                Console.WriteLine();
                m = 0;
            }
        }
    }
}

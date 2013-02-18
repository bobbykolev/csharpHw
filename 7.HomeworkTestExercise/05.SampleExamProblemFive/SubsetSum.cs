using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SubsetSum     // 0/100 - BGCoder
{
    static void Main(string[] args)
    {
        long S = long.Parse(Console.ReadLine());
        byte N = byte.Parse(Console.ReadLine());
        List<long> listN = new List<long>();
        for (byte i = 0; i < N; i++)
        {
            long n = long.Parse(Console.ReadLine());
            listN.Add(n);
        }


        for (byte j = 1; j <= N; j++)
        {
            for (byte k = 0; k < N; k++)
            {
                
            }
        }



    }
}

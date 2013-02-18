using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BynaryDigitsCount            //100/100 - BGCoder
{
    static void Main()
    {
        byte B = byte.Parse(Console.ReadLine());
        ushort N = ushort.Parse(Console.ReadLine());
        uint mask = 1;
        int sum1 = 0;
        int sum0 = 0;
        List<uint> listN = new List<uint>();
        for (int i = 0; i < N; i++)
        {
            uint n = uint.Parse(Console.ReadLine());
            listN.Add(n);
        }

        for (int j = 0; j < N; j++)
        {
            mask = 1;
            sum0 = 0;
            sum1 = 0;
            
            for (int k = 1; k <= 32; k++)
            {
                uint a = listN[j] & mask;
                if (a == mask)
                {
                    sum1++;
                }
                else if (a == 0 && mask <= listN[j])
                {
                    sum0++;
                }

                mask = mask << 1;
            }
            if (B == 1)
            {
                Console.WriteLine(sum1);
            }
            else if (B == 0)
            {
                Console.WriteLine(sum0);
            }
        }
    }
}

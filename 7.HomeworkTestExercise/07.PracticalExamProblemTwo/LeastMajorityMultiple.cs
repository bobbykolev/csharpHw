using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

class LeastMajorityMultiple //100/100 - BGCoder
{
    static void Main()
    {
        byte a = byte.Parse(Console.ReadLine());
        byte b = byte.Parse(Console.ReadLine());
        byte c = byte.Parse(Console.ReadLine());
        byte d = byte.Parse(Console.ReadLine());
        byte e = byte.Parse(Console.ReadLine());

        int result = 0;

        List<byte> listOf5 = new List<byte>() { a, b, c, d, e };

        for (int i = listOf5.Min(); i < (listOf5.Max() *100* 100); i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (i % listOf5[j] == 0)
                {
                    result++;
                }
            }
            if ((result == 3) || (result == 4) || (result == 5))
            {
                Console.WriteLine(i);
                break;
            }
            else 
            {
                result = 0;
            }
        }      
    }
}
       

 
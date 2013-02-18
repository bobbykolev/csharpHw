using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrimeWithSieveOfEratosthens
{
    static void Main()
    {
        bool[] arr = new bool[10000000];

        int sqr = (int)Math.Sqrt(arr.Length);

        for (int i = 2; i < sqr; i++)
        {
            if (arr[i] == false)
            {
                Console.WriteLine(i);
                for (int j = i * 2; j < arr.Length; j += i)
                {
                    arr[j] = true;
                }
            }
        }

        for (int i = sqr; i < arr.Length; i++)
        {
            if (arr[i] == false)
            {
                Console.WriteLine(i);
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class AllCombNK
{
    static int countloops;
    static int countIter;
    static int[] loops;

    static void Main()
    {

        Console.WriteLine("Enter N: ");
        countIter = int.Parse(Console.ReadLine());

        Console.Write("Enter K: ");
        countloops = int.Parse(Console.ReadLine());

        loops = new int[countloops];

        InnerL(0, 1);
    }
    static void Printloops()
    {
        for (int i = 0; i < countloops; i++)
        {
            Console.Write("{0} ", loops[i]);
        }
        Console.WriteLine();
    }

    static void InnerL(int loop, int CurrentNumber)
    {
        if (loop == countloops)
        {
            Printloops();
        }
        else
        {
            for (int i = CurrentNumber; i <= countIter; i++)
            {
                loops[loop] = i;
                InnerL(loop + 1, i + 1);
            }
        }
    }
}



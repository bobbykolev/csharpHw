using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class HandleOutOfGivenRange
{
    static int start = 1;
    static int end = 100;
    static void Main()
    {
        for (int i = 0; i < 10; i++)
        {
            start = ReadNumber(start, end);
        }

    }

    static int ReadNumber(int start, int end)
    {
        try
        {
            int n = int.Parse(Console.ReadLine());

            if ((start >= n) || (n >= end))
            {
                throw new OverflowException();
            }
            else
            {
                return n;
            }
        }
        catch (Exception)
        {
            throw new OverflowException();
        }
    }
}

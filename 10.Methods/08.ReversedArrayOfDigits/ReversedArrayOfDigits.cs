using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class ReversedArrayOfDigits
{

    static void Main()
    {
        byte[] firstArr = { 2, 4, 5, 8, 1, 9, 6, 7, 3 };
        byte[] secArr = { 9, 4, 6, 2, 0, 1, 0, 5, 2, 4, 9, 3 };

        Console.WriteLine(SumArrs(firstArr, secArr));
    }

     static BigInteger SumArrs(byte[] firstArr, byte[] secArr)
    {
        StringBuilder fSb = new StringBuilder();
        
        for (int i = firstArr.Length - 1; i >= 0; i--)
        {
            fSb.Append(firstArr[i]);
        }

        StringBuilder sSb = new StringBuilder();

        for (int i = secArr.Length - 1; i >= 0; i--)
        {
            sSb.Append(secArr[i]);
        }

        BigInteger fBi = BigInteger.Parse(fSb.ToString());
        BigInteger sBi = BigInteger.Parse(sSb.ToString());

        BigInteger result = fBi + sBi;

        return result;
    }
}

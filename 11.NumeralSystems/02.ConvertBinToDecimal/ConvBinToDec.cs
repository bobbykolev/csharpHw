using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ConvBinToDec
{
    static void Main()
    {
        Console.WriteLine("Enter a binary number:");
        string binNum = Console.ReadLine();
        int decNum = 0;
        for (int i = binNum.Length-1; i >= 0; i--)
        {
            if (binNum[i] == '1')
            {
                decNum += (int)Math.Pow(2, binNum.Length-i-1);
            }
        }
        Console.WriteLine("The decimal representation of the binary number {0} is: {1}", binNum, decNum);
    }
}

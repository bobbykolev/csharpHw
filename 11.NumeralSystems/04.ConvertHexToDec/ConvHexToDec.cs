using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ConvHexToDec
{
    static void Main()
    {

        string input = Console.ReadLine();
        string hexNum = input.ToUpper();
        Console.WriteLine(ReturnDecFromHex(hexNum, '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F'));
    }
    static int ReturnDecFromHex(string hexNum, params char[] hexArr)
    {
        int dec;
        int result = 0;
        for (int i = 0; i < hexNum.Length; i++)
        {
            dec = Array.IndexOf(hexArr, hexNum[i]);
            result += dec * (int)Math.Pow(16, hexNum.Length - i - 1);
        }

        return result;
    }
}

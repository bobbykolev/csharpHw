using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class HexToBin
{
    static char[] hexArr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
    static void Main()
    {
        string input = Console.ReadLine();
        string hexNum = input.ToUpper();
        Console.WriteLine(ReturnDecFromHex(hexNum));
    }
    static string ReturnDecFromHex(string hexNum)
    {
        string dec;
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < hexNum.Length; i++)
        {
            dec = Convert.ToString(Array.IndexOf(hexArr, hexNum[i]), 2);
            for (int j = dec.Length; j < 4; j++)
            {
                sb.Append('0');
            }
            sb.Append(dec);
        }
        return sb.ToString();
    }
}

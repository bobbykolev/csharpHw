using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BinaryToHex
{
    static void Main()
    {
        string bin = Console.ReadLine();

        StringBuilder sb = new StringBuilder();
        for (int i = bin.Length - 1; i >= 0; i--)
        {
            sb.Append(bin[i]);
   
        }
        while (sb.Length % 4 != 0)
        {
            sb.Append('0');
        }
        StringBuilder sb2 = new StringBuilder();
        for (int j = sb.Length - 1; j >= 0; j--)
        {
            sb2.Append(sb[j]);
            if (j%4==0)
            {
                Console.Write(SwitchHex(sb2).ToString().ToUpper());
                sb2.Clear(); 
            }

        } Console.WriteLine();
 
    }
    static char SwitchHex(StringBuilder sb2)
    {
        string singlehex = sb2.ToString();
        char result = ' ';
        switch (singlehex)
        {
            case "0000":
                result = '0'; break;
            case "0001":
                result = '1'; break;
            case "0010":
                result = '2'; break;
            case "0011":
                result = '3'; break;
            case "0100":
                result = '4'; break;
            case "0101":
                result = '5'; break;
            case "0110":
                result = '6'; break;
            case "0111":
                result = '7'; break;
            case "1000":
                result = '8'; break;
            case "1001":
                result = '9'; break;
            case "1010":
                result = 'a'; break;
            case "1011":
                result = 'b'; break;
            case "1100":
                result = 'c'; break;
            case "1101":
                result = 'd'; break;
            case "1110":
                result = 'e'; break;
            case "1111":
                result = 'f'; break;
            default:
                break;
        }
        return result;
    }
}

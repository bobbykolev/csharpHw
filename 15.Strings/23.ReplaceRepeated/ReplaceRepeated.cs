using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ReplaceRepeated
{
    static void Main()
    {
        string input = "aaaaabbbbbcdddeeeedssaa";
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < input.Length-1; i++)
        {
            if (input[i]!=input[i+1])
            {
                sb.Append(input[i]);
            }
        } 
        sb.Append(input[input.Length-1]);
        Console.WriteLine(sb.ToString());
    }
}


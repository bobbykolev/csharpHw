using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SplitDictionary
{
    static void Main()
    {
        string first = ".NET – platform for applications from Microsoft";
        string second = "CLR – managed execution environment for .NET";
        string third = "namespace – hierarchical organization of classes";

        string[] arrF = first.Split(new char[] { ' ', '-', ',' }, StringSplitOptions.RemoveEmptyEntries);
        string[] arrS = second.Split(new char[] { ' ', '-', ',' }, StringSplitOptions.RemoveEmptyEntries);
        string[] arrT = third.Split(new char[] { ' ', '-', ',' }, StringSplitOptions.RemoveEmptyEntries);
        string[] arr = {first, second, third };
        string[] words = { arrF[0], arrS[0], arrT[0]};

        string input = Console.ReadLine();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i]==input)
            {
                for (int j = words[i].Length; j < arr[i].Length; j++)
                {
                    sb.Append(arr[i][j]);
                }
                Console.WriteLine(sb.ToString());
            }
        }
    }
}

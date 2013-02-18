using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReadWordAndDisplayIndex
{
    static void Main()
    {
        char[] az = new char[26];
        for (int i = 0; i < 26; i++)
        {
            az[i] = (char)(65 + i);
        }
        string word = Console.ReadLine();
        
        for (int i = 0; i < word.Length; i++)
        {
            Console.Write(Array.IndexOf(az,word[i])+" ");
        }
        Console.WriteLine();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Compare2charArrays
    {



        static void Main()
        {
            char[] chars1 = { 'T', 'E', 'L', 'E', 'R', 'I', 'K' };
            char[] chars2 = { 'A', 'T', 'E', 'L', 'E', 'R', 'I', 'K' };

            StringBuilder ch1 = new StringBuilder();
            for (int i = 0; i < chars1.Length; i++)
            {
                ch1.Append(chars1[i]);
            }
            StringBuilder ch2 = new StringBuilder();
            for (int j = 0; j < chars2.Length; j++)
            {
                ch2.Append(chars2[j]);
            }

            string first = ch1.ToString();
            string second = ch2.ToString();

            string[] str = {first, second};
            Array.Sort(str);

            if (ch1.ToString()==ch2.ToString())
            {
                Console.WriteLine("The arrays are equal!");
            }
                
            else if (Array.IndexOf(str, first) == 0)
            {
                Console.WriteLine("First array is befor second one (lexicographically)!");
            }
            else
            {
                Console.WriteLine("Second array is befor first one (lexicographically)!");
            }
        }
    }

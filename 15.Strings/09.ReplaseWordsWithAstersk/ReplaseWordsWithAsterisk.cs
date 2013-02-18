using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class ReplaseWordsWithAsterisk
    {
        static void Main()
        {
            string text = "Microsoft announced its next generation PHP compiler today. It is based on "+
                ".NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            string[] words = {"PHP", "Microsoft", "CLR"};
            string result=text;
            for (int i = 0; i < words.Length; i++)
            {
                string replace = words[i]; 
                result = result.Replace(replace, new String('*', replace.Length));
            }
            Console.WriteLine(result);
        }
    }

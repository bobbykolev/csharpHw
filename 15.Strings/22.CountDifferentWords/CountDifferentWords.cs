using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class CountDifferentWords
    {
        static void Main()
        {
            string text = @"Lorizzle ipsum dolizzle sizzle shizznit, sizzle crunk elizzle. 
                            Nullam lorizzle crunk saw beyonces tizzles and my pizzle ipsum crizzle, 
                            ipsum sizzle, dizzle hizzle, sizzle vel, arcu.";
            text = text.ToLower();

            string[] words = text.Split(new char[] { ' ', ',', '.', '-', '!', '?', ':', ';', '(', ')', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            List<string> listW = words.ToList();
            
            List<int> count = new List<int>();
            for (int m = 0,n=1 ; m < listW.Count; m++)
            {
                count.Add(n);
            }


            for (int i = 0; i < listW.Count; i++)
            {
                for (int j = i; j < listW.Count; j++)
                {
                    if ((j>i) && (listW[i]==listW[j]))
                    {
                        listW[j] = "";
                        count[j] = 0;
                        count[i]++;
                    }
                }
            }
            for (int k = 0; k < listW.Count; k++)
            {
                if (listW[k] != "")
                {
                    Console.WriteLine("{0,-8} = {1} times;", listW[k], count[k]);
                }
            }
        }
    }

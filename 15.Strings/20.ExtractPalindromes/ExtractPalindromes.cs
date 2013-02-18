using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class ExtractPalindromes
    {
        static void Main()
        {                   //mom, noon and rotor
            string text = @"Curabitizzle brizzle dizzle mom dang fo shizzle yo mollizzle sizzle.
                            Vivamizzle noon neque. Dope orci. Crizzle mauris rotor shizzlin dizzle, interdizzle mah nizzle.";

            string[] arr = text.Split(new char[] {' ', ',', '.','-', '!', '?', ':', ';', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
            bool symmetric = true;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    symmetric = true;
                    if (arr[i][j] != arr[i][arr[i].Length - j - 1])
                    {
                        symmetric = false;
                        break;
                    }
                }
                if (symmetric==true)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }

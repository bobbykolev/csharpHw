using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class SortStringArr
    {
        static void Main()
        {
            //the array
            List<string> listN = new List<string>() { "abc", "abcde", "ab", "abcdef", "abcdefg" };
            //save sort result in new array
            List<string> listR = new List<string>() ;
            int n = listN.Count;

            for (int i = 0; i < n; i++)
            {
                listR.Add(listN.Max());
                listN.Remove(listN.Max());
            }
            foreach (var item in listR)
            {
                Console.WriteLine(item);
            }

        }
    }

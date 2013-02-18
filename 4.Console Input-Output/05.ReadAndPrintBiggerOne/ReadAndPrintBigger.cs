using System;
using System.Collections.Generic;
using System.Linq;

    class ReadAndPrintBigger
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            List<int> maxList = new List<int>() {a,b};
            Console.WriteLine(maxList.Max());
        }
    }

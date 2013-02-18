using System;
using System.Collections.Generic;
using System.Linq;

    class ReadNandPrint1ToN
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive integer \"n\":");
            int n = int.Parse(Console.ReadLine());
            List<int> list1 = new List<int>(n);
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }

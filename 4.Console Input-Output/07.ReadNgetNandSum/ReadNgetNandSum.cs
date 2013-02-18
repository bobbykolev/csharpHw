using System;
using System.Collections.Generic;
using System.Linq;

    class ReadNgetNandSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive integer \"n\" After that you must enter more \"n\" numbers separated by ENTERs :");
            int n = int.Parse(Console.ReadLine());
            //int j = int.Parse(Console.ReadLine());
            List<int> list1 = new List<int>(n);
            for (int i=0; i < n; i++)
			{
                Console.Write("{0}. - ", i+1);
                int j = int.Parse(Console.ReadLine());
			    list1.Add(j);
			}
            Console.WriteLine("The sum of the nembers that you've typed is = {0}", list1.Sum());
        }
    }

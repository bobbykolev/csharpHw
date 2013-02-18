using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class ReadAndPrintMinAndMax
    {
        static void Main()
        {
            Console.WriteLine("Specify the number of integers that you are about to type:");
            int n = int.Parse(Console.ReadLine());
            List<int> ListOf5 = new List<int>();
            for (int i = 0; i < n; i++)
			{
                int num = int.Parse(Console.ReadLine());
			    ListOf5.Add(num);
			}
            Console.WriteLine("Min = {0}\n\rMax = {1}", ListOf5.Min(), ListOf5.Max());
        }
    }

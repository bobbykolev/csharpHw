using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class SumNumsInStr
    {
        static void Main()
        {
            string input = "25 -25 67 -2 -15 50";//Console.ReadLine();

            string[] cleanStr = input.Split(' ');
            int n=0;
            int sum=0;
            for (int i = 0; i < cleanStr.Length; i++)
            {
                bool tryParse = int.TryParse(cleanStr[i], out n); 
                sum += n;
            }
            Console.WriteLine(sum);
        }
    }

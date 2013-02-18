using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class MostFrequentNum
    {
        static void Main()
        {
            int[] arr = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
            int sum = int.MinValue;
            int tSum = 1;
            int num = 0;
            int tNum=0;
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = 0; j < arr.Length-1; j++)
                {
                    if (arr[i]==arr[j+1])
                    {
                        tNum = arr[i];
                        tSum++;
                    }
                    if (tSum>sum)
                    {
                        sum = tSum;
                        num = tNum;
                    }
                } tSum = 1; 
            } Console.WriteLine("{0}({1} times)", num, sum);
        }
    }

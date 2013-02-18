using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class SeqOfMaxSum
    {
        static void Main()
        {
            int[] arr = { 1,2,3,4,   -2,   6,14,   -1,   2,3,4,};
            int temp = 0;
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                temp += arr[i];
                if ((temp < temp-arr[i]))
                {
                    if (temp-arr[i]>sum)
                    {
                        sum = temp - arr[i];
                    }
                    temp = 0;
                }
            } if (temp>sum)
            {
                Console.WriteLine("The maximum sequence sum = {0}", temp);
            }
            else
            {
                Console.WriteLine("The maximum sequence sum = {0}", sum);
            }
        }
    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class ReturnMinMaxAvgSum
    {
        static void Main()
        {
            Console.WriteLine(PrintMin(12, 4, 76, 2, -67, -2, 4, 6, 9));      //67
            Console.WriteLine(PrintMax(1, 4, 3, 7, -7, 48, 4, 56, 23));      //56
            Console.WriteLine(PrintSum(2, 1, 6, 2, -6, 12, 4, 6, 11));      //38
            Console.WriteLine(PrintAvg(46, 3, 5, 2, -17, 8, 2, -6, 9, 38));//9
          
        }

        private static int PrintAvg(params int[] arr)
        {
            int sum=0;
            
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            int avg = sum / arr.Length;
           
            return avg;
        }

        private static int PrintSum(params int[] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum+=arr[i];
            }

            return sum;
        }

        private static int PrintMax(params int[] arr)
        {
            int max = int.MinValue;
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            return max;
        }

        private static int PrintMin(params int[] arr)
        {
            int min = int.MaxValue;
            for (int i = 0; i <= arr.Length-1; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            return min;
        }
    }

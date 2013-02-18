using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class FindIndexViaBinarySearch
    {
        static void Main()
        {
            int[] arr = { 34, 1323, -324, -45, 1213, 21, 157, 12, 1, 34, 789, 32, 12, -34 };
            int K = -34;
            Array.Sort(arr);
            for (int i = arr.Length / 2; (i > 0) || (i < arr.Length); )
            {
                if (K > arr[i])
                {
                    i = i+arr.Length/4;
                }
                else if (K < arr[i])
                {
                    i /= 2;
                }
                else
                {
                    Console.WriteLine("The index of {0} is: {1}",K , i);
                    break;
                }
            }
        }
    }

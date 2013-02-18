using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class CheckIsItBiggerThanHisNeighbors
    {
        static void Main()
        {
            Console.WriteLine("Enter the position:");
            int n = int.Parse(Console.ReadLine());
           
        Console.WriteLine("Is bigger - {0}",CheckIntIsItBiggerThanHisNeighbors(n, 1, 32, 3, -23, -23, 56, 4, 2, 1, 9, -23));
        }

        static bool CheckIntIsItBiggerThanHisNeighbors(int n, params int[] arr)
        {
            bool isBigger = true;

            if ((n>0) && (n < arr.Length-1))
            {
                if (arr[n] > arr[n + 1] && arr[n] > arr[n -1])
                {
                    isBigger = true;
                }
                else
                {
                    isBigger = false;
                }
            }
            else
            {
                isBigger = false;
            }

            return isBigger;
        }
    }

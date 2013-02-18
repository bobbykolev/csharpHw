using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class ReturnIndexOfFirstBigger
    {
        static void Main()
        {

            Console.WriteLine("The Position is \"{0}\"", CheckIntIsItBiggerThanHisNeighbors( 1, 2, 2, -23, -23, 56, 4, 2, 1, 9, 56));

        }

        static int CheckIntIsItBiggerThanHisNeighbors(params int[] arr)
        {
            int position= 0;
            
            for (int i = 0; i < arr.Length; i++)
            {
                if ((arr[i] > arr[i + 1]) && (arr[i] > arr[i - 1]))
                {
                    position = i;
                    break;
                }
            }
 
            return position;
        }
    }

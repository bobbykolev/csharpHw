using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class MaxSequenceOfEqualElements
    {
        static void Main()
        {
            int[] arr = {1,2,3,3,4,4,4,5,6,7,7,8,8,8,8,9,9,9,};
            int result = 1;
            int temp = 1;

            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i]==arr[i+1])
                {
                    temp += 1;
                }
                else
                {
                    temp = 1;
                }
                if (temp>result)
                {
                    result = temp;
                }
            } Console.WriteLine(result);
        }
    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SortArray
{
    static void Main()
    {
        int[] arr = { 34, 1323, -324, -45, 1213, 21, 157, 12, 1, 34, 789, 32, 12, -34 };


        for (int j = 0; j < arr.Length; j++)
        {
            int min=arr[j];
            for (int i = j; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                    arr[i] = arr[j];
                    arr[j] = min;
                }
            }
        }
        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }

    }
}

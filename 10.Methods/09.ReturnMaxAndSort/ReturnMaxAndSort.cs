using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReturnMaxAndSort
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        Console.WriteLine(ReturnMaxAfterN(N, 45, -34, 547, 6, 23, 89, 345, 32, -345, 3, 98, 23));
        ReturnSortArr(45, -34, 547, 6, 23, 89, 345, 32, -345, 3, 98, 23);
    }
    static int ReturnMaxAfterN(int N, params int[] arr)
    {
        //Make new array that contain all ints from "arr" after N
        List<int> arrSec = new List<int> { };
        for (int i = N, j = 0; i < arr.Length; i++, j++)
        {
            arrSec.Add(arr[i]);
        }
        int max = arrSec.Max();
        arrSec.Remove(arrSec.Max());

        return max;
    }
    static void ReturnSortArr(params int[] arr)
    {
        int N = 0;
        List<int> arrSortD = new List<int> { };
        for (int j = 0; j < arr.Length; j++)
        {
            arrSortD.Add(ReturnMaxAfterN(N, arr));
            arr[Array.IndexOf(arr,ReturnMaxAfterN(N, arr))]=int.MinValue;
        }
        foreach (var item in arrSortD)
        {
            Console.WriteLine(item);
        }
    }
}

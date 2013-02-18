using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SortIntWithMergeSort
{
    static void Main()
    {
        int[] mainArr = { 34, -2, 3, 8, 5, 1 };
        //print the sorted Array
        foreach (var item in MergeSort(mainArr))
        {
            Console.WriteLine(item);
        }

    }
    //recursive method
    static int[] MergeSort(int[] mainArr)
    {
        if (mainArr.Length==1)
        {
            return mainArr;
        }
        int half = mainArr.Length / 2;

        int[] leftArr = new int[half];
        int[] rightArr = new int[mainArr.Length-half];
        
        for (int i = 0; i < half; i++)
        {
            leftArr[i] = mainArr[i];
        }
        for (int j = half; j < mainArr.Length; j++)
        {
            rightArr[j-half] = mainArr[j];
        }
        leftArr = MergeSort(leftArr);
        rightArr = MergeSort(rightArr);
        mainArr = SortTwo(leftArr, rightArr);
        return mainArr;
    }
    //sort lef an right and return sorted
    static int[] SortTwo(int[] leftArr, int[] rightArr)
    {
        int length = leftArr.Length + rightArr.Length;
        int[] sortArr = new int[length];
        for (int i = 0; i < leftArr.Length; i++)
        {
            sortArr[i] = leftArr[i];
        }
        for (int j = leftArr.Length, k = 0; j < length; j++, k++)
        {
            sortArr[j] = rightArr[k];
        }
        Array.Sort(sortArr);
        
        return sortArr;
    }
}

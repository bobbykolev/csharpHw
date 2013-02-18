using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SortUsingQuickSort
{
    static void Main()
    {
        List<int> mainArr = new List<int>(){ 3, -4, 19, 4, 15, 8 };

        foreach (var item in Sort(mainArr))
        {
            Console.WriteLine(item);
        }

    }
    static List<int> Sort(List<int> mainArr)
    {
        if (mainArr.Count<2)
        {
            return mainArr;
        }
        int pivotIndex = mainArr.Count / 2;
        List<int> left = new List<int>();
        List<int> right = new List<int>();
        int pivot = mainArr[pivotIndex];
        for (int i = 0; i < mainArr.Count; i++)
        {
            if (i != pivotIndex)
            {
                if (mainArr[i] < pivot)
                {
                    left.Add(mainArr[i]);
                }
                else 
                {
                    right.Add(mainArr[i]);
                }
            }
            
        }
        List<int> sorted = new List<int>();

        sorted.AddRange(Sort(left));
        sorted.Add(pivot);
        sorted.AddRange(Sort(right));

        return sorted;
    }
}

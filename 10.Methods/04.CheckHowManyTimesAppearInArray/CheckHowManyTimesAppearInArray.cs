using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CheckHowManyTimesAppearInArray
{
    static void Main()
    {
        Console.WriteLine(CheckMaxAppearsIntInArray(1, 32, 3, -23, -23, 56, 4, 2, 1, 9, -23));
    }
    static int CheckMaxAppearsIntInArray( params int[] arr)
    {
        int maxApp = 0;
        int tempMaxApp = 0;
        int max = 0, tempmax = 0;
        for (int j = 0; j < arr.Length; j++)
        {
            for (int i = j; i < arr.Length; i++)
            {
                tempMaxApp = 1;
                if (arr[j] == arr[i])
                {
                    tempMaxApp++;
                    tempmax = arr[i];
                }
            }
            if (tempMaxApp > maxApp)
            {
                maxApp = tempMaxApp;
                max = tempmax;
            }
        }
        return max;
    }
}

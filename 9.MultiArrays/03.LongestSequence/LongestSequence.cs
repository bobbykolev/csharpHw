using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LongestSequence
{
    static void Main()
    {
        

        //int n = int.Parse(Console.ReadLine());
        //int m = int.Parse(Console.ReadLine());

        //string[,] arr = new string[n, m];

        //for (int i = 0; i < n; i++)
        //    for (int j = 0; j < m; j++)
        //    {
        //        arr[i, j] = Console.ReadLine();
        //    }



        string[,] arr = new string[4, 5]
        {{"ho", "ha", "has", "ha", "ha" },
        {"hap", "ho", "has", "has", "has" },
        {"hap", "hop", "hos", "ha", "has" },
        {"hop", "hal", "hap", "h", "ho" }};

        int sum = 1;
        int temp = 1;
        string tempStr = "";
        string str = "";

        //check for horizontal max seq
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            temp = 1;
            for (int j = 0; j < arr.GetLength(1) - 1; j++)
            {

                if (arr[i, j] == arr[i, j + 1])
                {
                    temp++;
                    tempStr = arr[i, j + 1];
                }
                if (temp > sum)
                {
                    sum = temp;
                    str = tempStr;
                }
            }
        }
        //check for vertical max seq(works both if it's bigger or smaller than the horizontal max seq)
        for (int k = 0; k < arr.GetLength(1); k++)
        {
            temp = 1;
            for (int f = 0; f < arr.GetLength(0) - 1; f++)
            {

                if (arr[f, k] == arr[f + 1, k])
                {
                    temp++;
                    tempStr = arr[f + 1, k];
                }
                if (temp > sum)
                {
                    sum = temp;
                    str = tempStr;
                }
            }
        }
        temp = 1;
        for (int x = 0; x < arr.GetLength(1)-2; x++)
        {
            if (arr[x,x]==arr[x+1,x+1])
            {
                temp++;
                tempStr = arr[x , x];

            }
            if (temp > sum)
            {
                sum = temp;
                str = tempStr;
            }
        }
        temp = 1;
        for (int z = 0; z < arr.GetLength(1) - 3; z++)
        {
            if (arr[z+1, z] == arr[z + 2, z + 1])
            {
                temp++;
                tempStr = arr[z+1, z];

            }
            if (temp > sum)
            {
                sum = temp;
                str = tempStr;
            }
        }

        temp = 1;
        for (int y = 0; y < arr.GetLength(1) - 3; y++)
        {
            if (arr[y, y+1] == arr[y + 1, y + 2])
            {
                temp++;
                tempStr = arr[y, y + 1];

            }
            if (temp > sum)
            {
                sum = temp;
                str = tempStr;
            }
        }
        Console.WriteLine("{0}{1}", sum, str);
    }
}

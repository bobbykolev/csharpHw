using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MissCat      //100/100 - BGCoder
{
    static void Main()
    {
       int sum1 = 0;
       int sum2 = 0;
       int sum3 = 0;
       int sum4 = 0;
       int sum5 = 0;
       int sum6 = 0;
       int sum7 = 0;
       int sum8 = 0;
       int sum9 = 0;
       int sum10 = 0;
        int N = int.Parse(Console.ReadLine());
        List<int> listJury = new List<int>();
        for (int i = 1; i <= N; i++)
        {
            int catNum = int.Parse(Console.ReadLine());
            listJury.Add(catNum);

            if (catNum == 1)
            {
                sum1++;
            }
            else if (catNum == 2)
            {
                sum2++;
            }
            else if (catNum == 3)
            {
                sum3++;
            }
            else if (catNum == 4)
            {
                sum4++;
            }
            else if (catNum == 5)
            {
                sum5++;
            }
            else if (catNum == 6)
            {
                sum6++;
            }
            else if (catNum == 7)
            {
                sum7++;
            }
            else if (catNum == 8)
            {
                sum8++;
            }
            else if (catNum == 9)
            {
                sum9++;
            }
            else if (catNum == 10)
            {
                sum10++;
            }
            
            
        }
        List<int> listSum = new List<int>() { sum1, sum2, sum3, sum4, sum5, sum6, sum7, sum8, sum9, sum10 };


        switch (listSum.IndexOf(listSum.Max()))
        {
            case 0: Console.WriteLine("1");
                break;
            case 1: Console.WriteLine("2");
                break;
            case 2: Console.WriteLine("3");
                break;
            case 3: Console.WriteLine("4");
                break;
            case 4: Console.WriteLine("5");
                break;
            case 5: Console.WriteLine("6");
                break;
            case 6: Console.WriteLine("7");
                break;
            case 7: Console.WriteLine("8");
                break;
            case 8: Console.WriteLine("9");
                break;
            case 9: Console.WriteLine("10");
                break;
            default: Console.WriteLine("def");
                break;
        }
    }
}

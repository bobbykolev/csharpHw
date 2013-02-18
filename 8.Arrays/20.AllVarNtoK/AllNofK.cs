using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class AllNofK
{
    static void Main()
    {
        Console.WriteLine("Enter N: ");
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter K: ");
        int K = int.Parse(Console.ReadLine());
        Console.WriteLine();

        int index = K - 1;
        int helper = 0;

        List<int> list = new List<int>();
        for (int i = 0; i < K; i++) list.Add(1);

        while (true)
        {
            foreach (int item in list) Console.Write(item + " ");
            Console.WriteLine();

            while (index > -1 && list[index] == N)
            {
                helper = list[index];
                list[index] = 1;
                index--;
            }

            if (index == -1 && helper == N)
            {
                break;
            }
            list[index]++;
            index = K - 1;
        }
    }
}
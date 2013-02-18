using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Print1toNifNotDivOn3and7
    {
        static void Main()
        {
            Console.WriteLine("Type a ineger and press ENTER:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                if ((i % 3 != 0) && (i % 7 != 0))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

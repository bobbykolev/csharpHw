using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class FighterAttack
    {
        static void Main()
        {
            int px1 = int.Parse(Console.ReadLine());
            int py1 = int.Parse(Console.ReadLine());
            int px2 = int.Parse(Console.ReadLine());
            int py2 = int.Parse(Console.ReadLine());

            int fx1 = int.Parse(Console.ReadLine());
            int fy1 = int.Parse(Console.ReadLine());

            int d = int.Parse(Console.ReadLine());

            int minPx = Math.Min((px1), (px2));
            int maxPx = Math.Max((px1), (px2));

            int minPy = Math.Min((py1), (py2));
            int maxPy = Math.Max((py1), (py2));


            if (((fx1) + (minPx) - 1 > d) || ((fx1) + (maxPx) < d) || ((fy1) < (minPy) - 1) || ((fy1) > (maxPy) + 1))
            {
                Console.WriteLine("0%");

            }
            if (((fx1) + (minPx) < d) && ((fx1) + (maxPx) > d) && ((fy1) > (minPy)) && ((fy1) < (maxPy)))
            {
                    Console.WriteLine("275%");
            }   
            if ((((fx1) + (minPx) < d) && ((fx1) + (maxPx) > d-1) && (((fy1) == (minPy))  || ((fy1) == (maxPy)))))
            {
                Console.WriteLine("225%");
            }
            if (((fx1) + (minPx) -1 == d) && ((fy1) >= (minPy)) && ((fy1) <= (maxPy)))
            {
                Console.WriteLine("75%");
            }
            if (((fx1) + (minPx) < d) && ((fx1) + (maxPx) > d) && (((fy1) == (maxPy)) || ((fy1) == (minPy))))
            {
                Console.WriteLine("50%");
            }
        }
    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class SignedShortToBin
    {
        static void Main()
        {
            /*Използвал съм "Обратният код (one‘s complement)" за запис на отрицателно десетично в двоично. 
             Цитат от учебникът:
                "Обратният код (one‘s complement) се образува от правия код на числото, 
                 чрез инвертиране (заместване на всички нули с единици и единици с нули).
                 Числото -127 в прав код се представя като 1 1111111, а в обратен код като 1 0000000."*/

            short n=0;
            bool check = false;
            do
            {
                Console.WriteLine("Enter signed 16-bit integer:");
                check = short.TryParse(Console.ReadLine(), out n);
            } while (check==false);

            short sign = n;
            n =(short) Math.Abs(n);

            List<short> list = new List<short>();
            short p=0;
            do
            {
                p = (short) (n % 2);
                n = (short) (n / 2);
                list.Add(p);
            } while (n > 0);

            while (list.Count%4!=0)
            {
                list.Add(0); 
            }

            if (sign < 0)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (list[j] == 0)
                    {
                        list[j] = 1;
                    }
                    else
                    {
                        list[j] = 0;
                    }
                }
                for (int k = list.Count; k < 16; k++)
                {
                    list.Add(1);
                }
            }

            list.Reverse();

            Console.Write("The binary representation of {0} is: ",sign);
            foreach (var item in list)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }

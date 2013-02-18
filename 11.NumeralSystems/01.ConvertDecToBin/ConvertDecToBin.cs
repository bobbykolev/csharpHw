using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ConvertDecToBin
{
    static void Main()
        {
            int n;
            string str =Console.ReadLine();
            bool num = int.TryParse(str, out n);
            List<int> list = new List<int>();
            int p;
            do
			{
              p = n % 2;
              n = n / 2;
			 list.Add(p);
			}while (n>0);

            list.Reverse();
            foreach (var item in list)
            {
                Console.Write(item);
            }
        }

}

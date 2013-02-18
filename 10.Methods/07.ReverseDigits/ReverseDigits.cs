using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class ReverseDigits
    {
        static void Main()
        {
            string number = Console.ReadLine();
            Console.WriteLine(RevertDigits(number));
        }

        public static string RevertDigits(string number)
        {
           
            StringBuilder sb = new StringBuilder();

            for (int i = number.Length-1; i >= 0; i--)
            {
                  sb.Append(number[i]);
            }
            return sb.ToString();
        }
    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class String20chars
    {
        static void Main()
        {
            string input = Console.ReadLine();

            for (int i = 0; i < 20; i++)
            {
                if (i<input.Length)
                {
                    Console.Write(input[i]);
                }
                else
                {
                    Console.Write('*');
                }
            }
        }
    }

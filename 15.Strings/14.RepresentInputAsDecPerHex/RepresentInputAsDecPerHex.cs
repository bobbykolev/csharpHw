using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class RepresentInputAsDecPerHex
    {
        static void Main()
        {
            string input = Console.ReadLine();
            decimal dec = decimal.Parse(input);
            long hex = (long)dec;
            Console.WriteLine("{0,15}", dec);
            Console.WriteLine("{0,15:X}", hex);
            Console.WriteLine("{0,15:P}", dec);
            Console.WriteLine("{0,15:E}", dec);

        }
    }

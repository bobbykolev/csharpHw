using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class NsysSToNsysD
    {
        static void Main()
        {
            
            Console.Write("Enter numeral base from which to convert: ");
            int s = int.Parse(Console.ReadLine());

            Console.Write("Enter numeral base to which to convert: ");
            int d = int.Parse(Console.ReadLine());

            Console.Write("Enter a number to convert: ");
            string num = Console.ReadLine();

            string convNum = Convert.ToString(Convert.ToInt64(num, s), d).ToUpper();
            Console.WriteLine("The representation of the {0} \"base {1}\" to \"base {2}\" is: {3}", num, s, d, convNum);
            Console.WriteLine();
        }
    }


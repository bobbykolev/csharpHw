using System;
using System.Linq;
using System.Text;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the number and press enter:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of the bit (1 or 0) and press enter:");
            byte v = byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter the position of the bit press enter:");
            int p = int.Parse(Console.ReadLine());
            int result = (v << p);
            int bin = (result | n);

            Console.WriteLine("{0} ({1})", bin, Convert.ToString(bin, 2));
        }
    }

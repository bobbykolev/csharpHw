using System;

    class IfFirstBiggerExchange
    {
        static void Main()
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            int c = b;
            
            if (a>b)
            {
                 b = a;
                 a = c;
                Console.WriteLine("a = {0}, b = {1}", a, b);
            }
            else
            {
                Console.WriteLine("b > a");
            }
        }
    }

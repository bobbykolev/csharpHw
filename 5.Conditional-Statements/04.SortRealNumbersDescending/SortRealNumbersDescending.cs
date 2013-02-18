using System;

    class SortRealNumbersDescending
    {
        static void Main()
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            int c = int.Parse(Console.ReadLine());

            if (a>b && b>c)
            {
                Console.WriteLine("{0}, {1}, {2}", a, b, c);
            }
            if (a > c && c > b)
            {
                Console.WriteLine("{0}, {1}, {2}", a, c, b);
            }
            if (b > a && a > c)
            {
                Console.WriteLine("{0}, {1}, {2}", b, a, c);
            }
            if (b > c && c > a)
            {
                Console.WriteLine("{0}, {1}, {2}", b, c, a);
            }
            if (c > a && a > b)
            {
                Console.WriteLine("{0}, {1}, {2}", c, a, b);
            }
            if (c > b && b > a)
            {
                Console.WriteLine("{0}, {1}, {2}", c, b, a);
            }
            if (c == b && b == a)
            {
                Console.WriteLine("{0}, {1}, {2}", c, b, a);
            }
                        
        }
    }

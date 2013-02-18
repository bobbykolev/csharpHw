using System;


class PrintFromOneToN
    {
        static void Main()
        {
            Console.WriteLine("Type a ineger and press ENTER:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }

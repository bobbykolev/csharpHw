using System;

    class HowManyInts
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int sum=0;
            for (int i = a; i <= b; i++)
            {
                if (i%5==0)
                {
                   sum++ ;
                }
            }
            Console.WriteLine(sum);
        }
    }

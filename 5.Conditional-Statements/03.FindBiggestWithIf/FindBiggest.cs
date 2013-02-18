using System;

class FindBiggest
{
    static void Main()
    {
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("c = ");
        int c = int.Parse(Console.ReadLine());

        Console.Write("The biggest is:");

        if (a > b && a > c)
        {
            Console.WriteLine("a");
        }
        if (b > a && b > c)
        {
            Console.WriteLine("b");
        }
        if (c > a && c > b)
        {
            Console.WriteLine("c");
        }
        if (a == b && a > c)
        {
            Console.WriteLine("a and b");
        }
        if (a == c && a > b)
        {
            Console.WriteLine("a and c");
        }
        if (b == c && b > a)
        {
            Console.WriteLine("b and c");
        }
    }
}


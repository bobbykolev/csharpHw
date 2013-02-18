using System;

class FindLocation  //100/100 - BGCoder
{
    static void Main()
    {
        decimal X = decimal.Parse(Console.ReadLine());
        decimal Y = decimal.Parse(Console.ReadLine());

        if (X > 0 && Y > 0)
        {
            Console.WriteLine("1");
        }
        if (X < 0 && Y > 0)
        {
            Console.WriteLine("2");
        }
        if (X < 0 && Y < 0)
        {
            Console.WriteLine("3");
        }
        if (X > 0 && Y < 0)
        {
            Console.WriteLine("4");
        }
        if (X == 0 && (Y > 0 || Y < 0))
        {
            Console.WriteLine("5");
        }
        if (Y == 0 && (X > 0 || X < 0))
        {
            Console.WriteLine("6");
        }
        if (X==0 && Y==0)
        {
            Console.WriteLine("0");
        }
    }
}

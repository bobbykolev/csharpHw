using System;

    class TrapezoidArea
    {
        static void Main()
        {
            Console.WriteLine("Enter integer for trapezoid \"a\" side and press enter");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter integer for trapezoid \"b\" side and press enter");

            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter integer for trapezoid height \"h\" and press enter");

            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("(a+b)*h/2 = {0}", (a + b) * h / 2f);
        }
    }

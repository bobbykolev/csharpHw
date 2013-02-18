using System;

    class readIntsAndSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number c");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("a+b+c = {0}",(a+b+c));
        }
    }


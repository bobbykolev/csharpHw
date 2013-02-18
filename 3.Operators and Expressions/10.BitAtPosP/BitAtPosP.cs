using System;

    class BitAtPosP
    {
        static void Main()
        {
            Console.WriteLine("Enter the number");
            int v = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the position of the bit");
            int p = int.Parse(Console.ReadLine());

            bool isOne;

            int i = 1; 
            int mask = i << p;

            if ((v & mask) == 0)
            {
                isOne = false;
                Console.WriteLine("The {0} bite of {1} is one - {2}", p, v, isOne);
            }
            else
            {
                isOne = true;
                Console.WriteLine("The {0} bite of {1} is one - {2}", p, v, isOne);
            }
        }
    }

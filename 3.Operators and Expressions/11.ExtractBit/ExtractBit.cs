using System;

    class ExtractBit
    {
        static void Main()
        {
            Console.WriteLine("Enter the number");
            int v = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the position of the bit");
            int p = int.Parse(Console.ReadLine());

            int i = 1;
            int mask = i << p;

            if ((v & mask) == 0)
            {
                Console.WriteLine("The value of {1} bit of {1} is  0", p, v);
            }
            else
            {
                Console.WriteLine("The value of {1} bit of {1} is  1", p, v);
            }

        }
    }

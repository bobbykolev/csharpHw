using System;


    class ThirdBit
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = 8;
            int c = a & b;
            if (c == 0)
            {
                Console.WriteLine("The third bit in {0} is zero.", a);
            }
            else
            {
                Console.WriteLine("The third bit in {0} is one.", a);
            }
            

        }
    }

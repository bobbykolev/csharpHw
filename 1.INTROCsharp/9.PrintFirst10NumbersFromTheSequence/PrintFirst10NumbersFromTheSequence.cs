using System;

    class PrintFirst10NumbersFromTheSequence
    {
        static void Main()
        {
            sbyte a = 2;
            sbyte b = -3;

            while (b>-12 && a<12)
            {
                Console.WriteLine("{0}\n{1}", a,b);
                a += 2;
                b -= 2;
                
            }
        }
    }


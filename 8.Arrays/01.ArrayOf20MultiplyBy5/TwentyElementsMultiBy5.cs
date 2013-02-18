using System;

namespace _01.ArrayOf20MultiplyBy5
{
    class TwentyElementsMultiBy5
    {
        static void Main()
        {
            int[] arrayOf20 = new int[20];

            for (int i = 0; i < 20; i++)
            {
                arrayOf20[i]=i*5;
                Console.WriteLine(arrayOf20[i]);
            }
        }
    }
}

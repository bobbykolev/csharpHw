using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

    class First100Fibonacci
    {
        static void Main()
        {
                    BigInteger first = 0;
                    BigInteger second = 1;
                    BigInteger third;
                    Console.WriteLine("1. - 0");
                    Console.WriteLine("2. - 1");
                    for (int i = 0; i < 98; i++)
                    {
                        third = first + second;
                        first = second;
                        second = third;
                        
                        Console.WriteLine("{0}. - {1}", i+3, third);
                    }
        }
    }

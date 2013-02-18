using System;
using System.Collections.Generic;
using System.Linq;

    class ApplyBonus
    {
        static void Main()
        {
            Console.WriteLine("Enter the score (1-9) to see it with bonus:");
                ushort n = ushort.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                    case 2:
                    case 3:
                        n *= 10;
                        Console.WriteLine(n);
                        break;
                    case 4:
                    case 5:
                    case 6:
                        n *= 100;
                        Console.WriteLine(n);
                        break;
                    case 7:
                    case 8:
                    case 9:
                        n *= 1000;
                        Console.WriteLine(n);
                        break;
                    default:
                        Console.WriteLine("ERROR please enter a valid score (1-9)");
                        break;
                }
        }
    }

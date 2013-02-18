using System;
    class ShowSign
    {
        static void Main()
        {
           Console.Write("a = ");
           double a = double.Parse(Console.ReadLine());
           Console.Write("b = ");
           double b = double.Parse(Console.ReadLine());
           Console.Write("c = ");
           double c = double.Parse(Console.ReadLine());

           if (a == 0 || b == 0 || c == 0)
           {
               Console.WriteLine("The product is zero");
           }
           else
           {
               if ((a > 0 && b > 0 && c > 0) || (a < 0 && b < 0 && c > 0) || (a < 0 && b > 0 && c < 0) || (a > 0 && b < 0 && c < 0))
               {
                   Console.WriteLine("The product is positive number");
               }
               else
               {
                   Console.WriteLine("The product is negative number");
               } 
           }

        }
    }

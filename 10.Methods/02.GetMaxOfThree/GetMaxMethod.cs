using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class GetMaxMethod
    {

        static void Main()
        {
            Console.WriteLine("Enter first number:");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int second = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number:");
            int third = int.Parse(Console.ReadLine());


            Console.WriteLine("The biggest number is {0}", GetMax(GetMax(first, second), third)); 


        }
        static int GetMax(int first, int second)
        {
            int bigger = first;
            if (second>bigger)
            {
                bigger = second;
            }
            return bigger;
        }
    }

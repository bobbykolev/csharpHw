using System;


    class OddOrEven
    {
        static void Main()
        {
            Console.Write("Type a number and press enter:");
            int a = int.Parse(Console.ReadLine());
            
            if (a % 2 == 0)
            {
               Console.WriteLine("{0} it's Even",a);
            }
            else
	        {
               Console.WriteLine("{0} it's Odd",a);
	        }
        }
    }

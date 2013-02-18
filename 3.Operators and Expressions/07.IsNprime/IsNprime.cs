using System;

    class IsNprime
    {
        static void Main()
        {
            Console.WriteLine("Enter number between 1 and 100 and see is it prime");
            int n = int.Parse(Console.ReadLine());
            int i;
            
            for (i = 2; i < 10 ; i++)
            {
                if (n % i == 0 && n != i )
                    {
                        Console.WriteLine("{0} is not prime", n);
                        break; 
                    }
                    else
                    {
                        Console.WriteLine("{0} is prime", n);
                        break;
                    }
                }
            }
        }
    

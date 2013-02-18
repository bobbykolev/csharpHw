using System;


    class DeclareTwoIntAndSwap
    {
        static void Main()
        {
            int first = 5;
            int second = 10;
                        
            Console.WriteLine("Fist Number = {0}", first);
            Console.WriteLine("Second Number = {0}", second);

            second -= first;
            first += first;
            
            Console.WriteLine("Fist Number = {0}", first);
            Console.WriteLine("Second Number = {0}", second);
        }
    }

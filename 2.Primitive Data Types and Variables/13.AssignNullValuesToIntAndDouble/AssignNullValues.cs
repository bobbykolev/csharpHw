using System;

    class AssignNullValues
    {
        static void Main()
        {
            int? nullInt = null;
            double? nullDouble = null;
            Console.WriteLine("|{0}| and |{1}|", nullInt, nullDouble);
            nullInt += 10;
            nullDouble *= 10;
            Console.WriteLine("|{0}| and |{1}|", nullInt, nullDouble);
        
            int a = 5;
            int? isItNulla = a;
            double b = 12.02;
            double? isItNullb = b;
            Console.WriteLine("|{0}| and |{1}|", isItNulla, isItNullb);
            isItNulla -= 5;
            isItNullb -= 12;
            Console.WriteLine("|{0}| and |{1}|", isItNulla, isItNullb);
        }
    }


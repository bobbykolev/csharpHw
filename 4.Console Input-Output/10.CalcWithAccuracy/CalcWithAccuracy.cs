using System;

    class CalcWithAccuracy
    {
        static void Main()
        {
            double posSum = 0;
            double negSum = 0;
            
            for (double i = 2, j=3;; i+=2, j+=2)
            {
                posSum += (1 / i);
                negSum += (1/j);
                
                if (posSum-(posSum-1/i)< 0.001)
                {
                    Console.WriteLine(posSum - negSum +1);
                    break;
                }
                
            }
        }

    }

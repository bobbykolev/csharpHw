using System;
using System.Numerics;

class AstrologicalDigits
{
    static void Main()
    {
        

        string str = Console.ReadLine();
        string strCleanFirst = str.Replace(".", "");
        string strClean = strCleanFirst.Replace("-", "");
        BigInteger n;
        bool yes = BigInteger.TryParse(strClean, out n);
        BigInteger a;
        BigInteger sum = 0;
        BigInteger sum1 = 0;
        BigInteger sum2 = 0;
        BigInteger sum3 = 0;

        while (n > 0)
        {
            a = n % 10;
            sum = sum + a;
            n = n / 10;
        }
        if (sum < 10)
        {
            Console.WriteLine(sum);
        }
        else
        {
            while (sum > 0)
            {
                a = sum % 10;
                sum1 += a;
                sum = sum / 10;
            }
            if (sum1 < 10)
            {
                Console.WriteLine(sum1);
            }
            else
            {
                while (sum1 > 0)
                {
                    a = sum1 % 10;
                    sum2 += a;
                    sum1 = sum1 / 10;
                }
                if (sum2 < 10)
                {
                    Console.WriteLine(sum2);
                }
                else
                {
                    while (sum2 > 0)
                    {
                        a = sum2 % 10;
                        sum3 += a;
                        sum2 = sum2 / 10;
                    } if (sum3 < 10)
                    {
                        Console.WriteLine(sum3);
                    }
                }
            }
        }
    }
}

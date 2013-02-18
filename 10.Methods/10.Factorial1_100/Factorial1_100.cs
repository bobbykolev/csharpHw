using System;
using System.Numerics;

class Factorial1_100
{
    static void Main()
    {
        /*В slid-a пише, че решението с масив е подсказка(hint), а не е задължително, а в учебника:
          
         "Друг, по-лесен вариант да работите с големи числа като 100!, е чрез библиотеката System.Numerics.dll, 
         която можете да използвате в проектите си като преди това добавите референция към нея. Потърсете информация 
         в Интернет как да използвате библиотеката и класът System.Numerics.BigInteger."
         
         Съответно използвам изключително каратко (и бързо) решение с BigInteger и рекурсия*/

        Console.WriteLine("Enter the number [1-100]");
        int n = int.Parse(Console.ReadLine());

        BigInteger result = Factorial(n);
        Console.WriteLine("{0}! = {1}", n, result);
    }

    static BigInteger Factorial(BigInteger n)
    {

        if (n == 0)
        {
            return 1;
        }

        else
        {
            return n * Factorial(n - 1);
        }
    }
}

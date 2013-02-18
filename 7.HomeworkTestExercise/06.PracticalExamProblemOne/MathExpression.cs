using System;
using System.Numerics;
using System.Threading;
using System.Globalization;

class MathExpression
{
    static void Main()  //100/100 - BGCoder
    {

        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        double N = double.Parse(Console.ReadLine());
        double M = double.Parse(Console.ReadLine());
        double P = double.Parse(Console.ReadLine());

        Console.WriteLine("{0:F6}", (((N*N)+(1/(M*P))+1337)/(N-(128.523123123*P)))+ Math.Sin((int)M % 180));
    }

}
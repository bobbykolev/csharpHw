using System;
using System.Threading.Tasks;


class EnterCoeffAndPrintRoots
{
    static void Main()
    {
        Console.WriteLine("Enter number a:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter number b");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter number c");
        double c = double.Parse(Console.ReadLine());
        if (a == 0)
        {
            Console.WriteLine("x = {0}", c / b);
        }
        if (a != 0)
        {
            double sqroot = b * b - 4 * a * c;
            double x1 = (-b + (Math.Sqrt(sqroot))) / 2 * a;
            double x2 = (-b - (Math.Sqrt(sqroot))) / 2 * a;
            if (sqroot < 0)
            {
                Console.WriteLine("x1=There is no real number,x2=There is no real number");
            }
            else
            {
                Console.WriteLine("x1={0},x2={1}", x1, x2);
            }

        }
    }
}

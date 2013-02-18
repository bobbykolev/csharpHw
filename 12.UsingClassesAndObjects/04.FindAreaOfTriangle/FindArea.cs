using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class FindArea
    {
        static double area = 0;
        static void Main()
        {
            Console.WriteLine("Choose method:");
            Console.WriteLine("For side and an altitude to it - Enter \"2\"");
            Console.WriteLine("For three sides - Enter \"1\"");
            Console.WriteLine("For two sides and an angle between them - Enter \"3\"");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("a = ");
                    double a = double.Parse(Console.ReadLine());
                    Console.Write("h = ");
                    double h = double.Parse(Console.ReadLine());
                    Console.WriteLine("The area is = {2}", ReturnArea_ah(a,h));
                    break;
                case 2:
                    Console.Write("a = ");
                    a = double.Parse(Console.ReadLine());
                    Console.Write("b = ");
                    double b = double.Parse(Console.ReadLine());
                    Console.Write("c = ");
                    double c = double.Parse(Console.ReadLine());
                    Console.WriteLine("The area is = {0}", ReturnArea_abc(a, b, c));
                    break;
                case 3:
                    Console.Write("a = ");
                    a = double.Parse(Console.ReadLine());
                    Console.Write("b = ");
                    b = double.Parse(Console.ReadLine());
                    Console.Write("alpha (in degrees) = ");
                    int alpha = int.Parse(Console.ReadLine());
                    Console.WriteLine("The area is = {0}", ReturnArea_abAlpha(a, b, alpha));
                    break;
                default: break;
            }
            
        }
        static double ReturnArea_ah(double a, double h)
        {
            area = (a * h) / 2;
            return area;
        }
        static double ReturnArea_abc(double a, double b, double c)
        {
            double s = (a + b + c) / 2;
            double areaPow2 = s * (s - a) * (s - b) * (s - c);
            area = Math.Sqrt(areaPow2);
            return area;
        }
        static double ReturnArea_abAlpha(double a, double b, int alpha)
        {
            
            area = ((a*b)/2)*Math.Sin(Math.PI*alpha/180);
            return area;
        }
    }

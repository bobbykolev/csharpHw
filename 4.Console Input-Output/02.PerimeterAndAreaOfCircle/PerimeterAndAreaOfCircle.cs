using System;

    class PerimeterAndAreaOfCircle
    {
        static void Main()
        {
            Console.WriteLine("Enter radius r");
            double r = double.Parse(Console.ReadLine());
            double c = Math.PI*r*r;
            double area = 2 * Math.PI * r;

            Console.WriteLine("The perimeter of the circle with radius \"{0}\" = {1:0.00}", r, c);
            Console.WriteLine("The perimeter of the circle with radius \"{0}\" = {1:0.00}", r, area);
        }
    }

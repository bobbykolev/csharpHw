using System;

    class PointInCircle
    {
        static void Main()
        {
            Console.WriteLine("Enter first coordinate of the point and press enter");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter second coordinate of the point and press enter");
            float b = float.Parse(Console.ReadLine());

            if ((a * a) + (b * b) <= 25)
            {
                Console.WriteLine("The point is in the circle");
            }
            else
            {
                Console.WriteLine("The point is out of the circle");
            }
        }
    }

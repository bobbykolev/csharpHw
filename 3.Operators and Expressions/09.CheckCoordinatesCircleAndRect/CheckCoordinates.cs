using System;

class CheckCoordinates
    {
        static void Main()
        {
            Console.WriteLine("Enter first coordinate of the point and press enter");
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter second coordinate of the point and press enter");
            float y = float.Parse(Console.ReadLine());

            if (((x-1) * (x-1)) + ((y-1) * (y-1)) <= 9)
            {
                if (x > 1 && y < -1)
                {
                    Console.WriteLine("The point is in the circle, but it's in the rectangle");
                }
                else
                {
                    Console.WriteLine("The point is in the specified location");
                }
	         }
            else
	        {
                Console.WriteLine("The point is out of the specified location");
	        }
        }
    }

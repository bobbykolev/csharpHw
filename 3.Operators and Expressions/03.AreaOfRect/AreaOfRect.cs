using System;


class AreaOfRect
{
    static void Main()
    {
        Console.WriteLine("Type the width of a rectangle");
        int width = int.Parse(Console.ReadLine());
        Console.WriteLine("Type the height of a rectangle");
        int height = int.Parse(Console.ReadLine());

        Console.Write("The area of the rect = ");
        Console.WriteLine(width * height);
    }
}
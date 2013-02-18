using System;

class ReadMyAgeAndAddTen
{


    static void Main()
    {
        Console.WriteLine("Enter your current age(use numbers) and press ENTER");
        sbyte incr = 10;
        sbyte currAge = sbyte.Parse(Console.ReadLine());
        Console.WriteLine("Your age after 10 years, will be: " + (currAge + incr));
    }

}
using System;


class DividedBy7and5
{
    static void Main()
    {
        Console.WriteLine("Type a integer and press enter:");
        int a = int.Parse(Console.ReadLine());
        bool number;

        if (a % 5 == 0 && a%7 == 0)
        {
            number = true;
            Console.WriteLine("The {0} can be divided by 7 and 5 without reminder - {1}", a, number);
        }
        else
        {
            number = false;
            Console.WriteLine("The {0} can be divided by 7 and 5 without reminder - {1}", a, number);
        }
        
    }
}







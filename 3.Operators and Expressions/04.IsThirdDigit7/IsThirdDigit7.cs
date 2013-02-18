using System;


class IsThirdDigit7 
{
    static void Main()
    {
        Console.WriteLine("Type a n-digit number (n>3; n<10) and press enter:");
        int a = int.Parse(Console.ReadLine());

        a /= 100;
        bool number;

        if (a % 10 == 7)
        {
            number = true;
            Console.WriteLine("The third digit from right to left is 7 - {0}", number);
        }
        else
        {
            number = false;
            Console.WriteLine("The third digit from right to left is 7 - {0}", number);
        }
        
    }
}

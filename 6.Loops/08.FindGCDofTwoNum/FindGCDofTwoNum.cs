using System;

class FindGCDofTwoNum
{
    static void Main()
    {
        Console.WriteLine("Type first number and press ENTER:");
        int firstInput = int.Parse(Console.ReadLine());
        Console.WriteLine("Type second number and press ENTER:");
        int secondInput = int.Parse(Console.ReadLine());

        while (firstInput!= 0 && secondInput!= 0)
        {
            if (firstInput> secondInput)
            {
                firstInput %= secondInput;
            }
            else
            {
                secondInput %= firstInput;
            }
        }

        if (firstInput == 0)
        {
            Console.WriteLine("The GCD is {0}", secondInput);
        }
        else
        {
            Console.WriteLine("The GCD is {0}", firstInput);
        }
    }
}

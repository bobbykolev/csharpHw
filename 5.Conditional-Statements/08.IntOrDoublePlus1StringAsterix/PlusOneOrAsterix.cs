using System;

class PlusOneOrAsterix
{
    static void Main()
    {
        Console.WriteLine("Type a string or a number: ");
        string inputVar = Console.ReadLine();
        int iVar;
        double dVar;
            
        bool itSint;
        bool itSdouble;

        if (itSint = int.TryParse(inputVar, out iVar))
        {
            iVar++;
            Console.WriteLine(iVar);
        }
        else if (itSdouble = double.TryParse(inputVar, out dVar))
        {
            dVar++;
            Console.WriteLine(dVar);
        }
        else
        {
            Console.WriteLine(inputVar + "*");
        }
    }
}

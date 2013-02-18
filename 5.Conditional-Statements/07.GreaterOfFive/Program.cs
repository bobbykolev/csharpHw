using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter \"5\" variables separated by ENTER :");
        int n = 5;
        List<string> listOfFive = new List<string>(n);
        for (int i=0; i < n; i++)
		{
            Console.Write("{0} - ", i+1);
            string j = Console.ReadLine();
			listOfFive.Add(j);
		}
        Console.WriteLine("The greatest is = {0}", listOfFive.Max());
    }
}


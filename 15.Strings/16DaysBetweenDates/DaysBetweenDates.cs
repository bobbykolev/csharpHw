using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DaysBetweenDates
{
    static void Main()
    {
        Console.Write("Enter the first date (date.month.year): ");
        string first = Console.ReadLine();
        Console.Write("Enter the second date (date.month.year): ");
        string second = Console.ReadLine();

        string[] arrF = first.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
        string[] arrS = second.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);


        DateTime firstDate = new DateTime(int.Parse(arrF[2]), int.Parse(arrF[1]), int.Parse(arrF[0]));
        DateTime secondDate = new DateTime(int.Parse(arrS[2]), int.Parse(arrS[1]), int.Parse(arrS[0]));

        int length = (secondDate - firstDate).Days;

       
        Console.WriteLine("Distance: {0}", length);
    }
}

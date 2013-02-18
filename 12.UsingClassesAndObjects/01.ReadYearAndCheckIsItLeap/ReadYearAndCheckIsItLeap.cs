using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class ReadYearAndCheckIsItLeap
    {
        static void Main()
        {
            short year = short.Parse(Console.ReadLine());
            Console.WriteLine("The {0} is Leap - {1}.", year, DateTime.IsLeapYear(year));
        }
    }

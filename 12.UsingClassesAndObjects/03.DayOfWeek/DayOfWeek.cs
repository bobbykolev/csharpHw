using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class DayOfWeek
    {
        static void Main()
        {
            Console.WriteLine("Enter a day:");
            byte day = byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter a month:");
            byte month = byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter a year:");
            short year = short.Parse(Console.ReadLine());
            DateTime dow = new DateTime(year,month,day);
            Console.WriteLine(dow.DayOfWeek);
        }
    }

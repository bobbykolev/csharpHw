using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class WorkDaysBetweenDates
    {
        static void Main()
        {
            DateTime[] holidays =
        {
            new DateTime(2014, 1, 1),
            new DateTime(2013, 12, 25),
            new DateTime(2013, 12, 26),
            new DateTime(2013, 9, 6),
            new DateTime(2013, 9, 22),
            new DateTime(2013, 3, 3),
            new DateTime(2013, 3, 31),
            new DateTime(2013, 5, 6)
        };


            DateTime today = DateTime.Today;
            Console.Write("Enter a date (YYYY-MM-DD) : ");      
            DateTime final = DateTime.Parse(Console.ReadLine());

            int workDays = 0;
            int length = (final - today).Days;

            for (int i = 1; i <= length; i++)
            {
                DateTime check = today.AddDays(i);
                if ((check.DayOfWeek != DayOfWeek.Sunday) && (check.DayOfWeek != DayOfWeek.Saturday))
                {
                    workDays++;
                }
                for (int j = 0; j < holidays.Length; j++)
                {
                    if ((check == holidays[j]) && (holidays[j].DayOfWeek != DayOfWeek.Sunday) && (holidays[j].DayOfWeek != DayOfWeek.Saturday))
	                {
                        workDays--;
	                } 
                }
                
            } Console.WriteLine(workDays);
        }
    }

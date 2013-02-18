using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;

    class DateTimeCanada
    {
        static void Main()
        {
            string text = @"Etiam laoreet crazy nisl. Ma nizzle quizzle 22.05.2012 arcu. 
                             Maecenizzle pulvinar, ipsizzle uhuh ... yih! malesuada , nulla shizzlin dizzle euismizzle felis, 
                             shut the shizzle up you son of a bizzle 31.12.2013 metizzle shit et go to hizzle.";

            foreach (Match m in Regex.Matches(text, @"\d{2}.\d{2}.\d{4}"))
            {
                DateTime dt = DateTime.ParseExact(m.Value, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                Console.WriteLine(dt.ToString(CultureInfo.GetCultureInfo("en-CA")));
            }
        }
    }

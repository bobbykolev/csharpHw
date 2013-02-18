using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

    class Email
    {
        static void Main()
        {
            string text = @"Lorizzle ipsizzle for john_doe@john-bg.com sure sit amizzle, shit check out this pimpin'.
                            Nullizzle mammasay mammasa info1.academy@telerik.co.uk mamma oo sa velizzle, daahng dawg volutpizzle, 
                            suscipizzle quis, gravida vizzle, fo.";

            foreach (Match m in Regex.Matches(text, @"[\w-_\.]{2,}@[\w-_\.]{2,}\.[a-zA-Z]{2,5}"))
            {
                Console.WriteLine(m.Value);
            }
        }
    }

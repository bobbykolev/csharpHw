using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

class ExtractUrlParts
{
    static void Main()
    {
        string url = @"http://www.codeproject.com/Articles/9099/The-30-Minute-Regex-Tutorial";

        
        Console.WriteLine("[protocol] = " + "\"" + Regex.Match(url, @"^\w+") + "\"");
        Console.WriteLine("[server] = " + "\"" + Regex.Match(url, @"\w+\.\w+\.\w+") + "\"");
        url = Regex.Replace(url, Regex.Match(url, @"^\w+").ToString(), "");
        url = Regex.Replace(url, Regex.Match(url, @"\w+\.\w+\.\w+").ToString(), "");
        url = Regex.Replace(url, Regex.Match(url, @"://").ToString(), "");
        Console.WriteLine("[resource] = " + "\"" + url + "\"");
       
    }
}

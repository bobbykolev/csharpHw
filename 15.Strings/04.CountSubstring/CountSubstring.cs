using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CountSubstring
{
    static void Main()
    {
        string text = "We are living in an yellow submarine. We don't have anything else." +
        "Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        text = text.ToLower();
        string substring = "in";
        int index = text.IndexOf(substring);
        int counter = 0;
        while (index != -1)
        {
            counter++;
            index = text.IndexOf(substring, index + 1);
        }

        Console.WriteLine(counter);

    }
}

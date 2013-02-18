using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

    class RemoveSentenceWithSubStr
    {
        static void Main()
        {
            string text = "We are living in a yellow submarine. We don't have anything else." +
                " Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";

            string temp="";
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                sb.Append(text[i]);
                if (text[i]=='.')
                {

                    if ((sb.ToString().IndexOf(" in ") != -1) || (sb.ToString().IndexOf(" in.") != -1) || (sb.ToString().IndexOf(" In ") != -1))
                    {
                        temp += sb.ToString();
                    }
                    sb.Clear();
                }
            } Console.WriteLine(temp);
        }
    }

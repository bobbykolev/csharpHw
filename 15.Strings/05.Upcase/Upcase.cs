using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Upcase
    {
        static void Main()
        {
            string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
            string temp = text;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i]== '<')
                {
                    if (temp[i+1]!='/')
                    {
                        i = i + 8;
                        temp = text.ToUpper();
                    }
                    else 
                    {
                        i = i + 9;
                        temp = text;
                    }
                }
                sb.Append(temp[i]);
            }
            Console.WriteLine(sb.ToString());
        }
    }

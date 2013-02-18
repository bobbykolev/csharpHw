using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

    class ExtractFromHtml
    {
        static void Main()
        {
            string html = "../../index.html";

            System.Text.Encoding encoding = System.Text.Encoding.GetEncoding(1251);

            StreamReader streamReader = new StreamReader(html, encoding);
            
            string text;
            using (streamReader) 
            {
                string line = streamReader.ReadLine();
                text = line;
                while (line != null)
                {
                    text += line;
                    line = streamReader.ReadLine();
                }
            }
            //Above we extract the content from the index.html to string "text".


            //Now I replace every tag with RegEx pattern (/<(.*?)>/)
            Regex rgx = new Regex(@"<(.*?)>");
            string result = rgx.Replace(text," ");

            //Using StringBuilder I get rid of some unwanted spaces.
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < result.Length-1; i++)
            {
                if ((result[i] == ' ') && (result[i]==result[i+1]))
                {
                    continue;
                }
                else 
                {
                    sb.Append(result[i]);
                }
            }
            Console.WriteLine(sb.ToString().Trim());
        }
    }

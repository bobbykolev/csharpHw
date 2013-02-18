using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;


class ReplacePrefix
{
    static void Main()
    {
        string folder = "../../";
        string firstF = "test.txt";
    
        string inputF = folder + firstF;
      
        System.Text.Encoding encoding = System.Text.Encoding.GetEncoding(1251);
        int i = 0;

        try
        {
            StreamReader streamReader = new StreamReader(inputF, encoding);
            using (streamReader)
            {
               
                    string line = streamReader.ReadLine();
                    while (line != null)
                    {
                        i++;
                        Console.WriteLine("{0}.{1}", i, line);
                        Console.WriteLine("{0}.{1}", i, Regex.Replace(line, "\\btest\\w{1,}", ""));
                        Console.WriteLine();
                        line = streamReader.ReadLine();
                    }
                
            }

        }
        catch (FileNotFoundException)
        {
            Console.Error.WriteLine("Can't find file {0}.", firstF);
        }
        catch (IOException)
        {
            Console.Error.WriteLine("Can't read the file {0}.", firstF);
        }
    }
}

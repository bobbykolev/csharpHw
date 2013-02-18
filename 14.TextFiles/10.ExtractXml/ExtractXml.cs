using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class ExtractXml
{

    static void Main()
    {

        string folder = "../../";
        string firstF = "test.xml";

        string inputF = folder + firstF;

        System.Text.Encoding encoding = System.Text.Encoding.GetEncoding(1251);

        try
        {
            StreamReader streamReader = new StreamReader(inputF, encoding);
            StringBuilder sb = new StringBuilder();

            using (streamReader)
            {

                string line = streamReader.ReadLine();
                while (line != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] == '<')
                        {
                            while (line[i] != '>')
                            {
                                i++;
                            }
                            continue;
                        }
                        else
                        {
                            sb.Append(line[i]);
                        }
                    }
                    Console.WriteLine(sb);
                    sb.Clear();
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

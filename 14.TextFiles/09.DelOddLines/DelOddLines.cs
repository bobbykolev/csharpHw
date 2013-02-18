using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class DelOddLines
{
    static void Main()
    {

        string folder = "../../";
        string firstF = "test.txt";

        string inputF = folder + firstF;



        System.Text.Encoding encoding = System.Text.Encoding.GetEncoding(1251);


        try
        {
            StreamReader streamReader = new StreamReader(inputF, encoding);
            List<string> str = new List<string>();
            int count = 0;
            using (streamReader)
            {

                string line = streamReader.ReadLine();
                while (line != null)
                {
                    count++;
                    if ((count & 1) != 1)
                    {
                        str.Add(line);
                    }
                    line = streamReader.ReadLine();
                }
                

            }
            StreamWriter streamWriter = new StreamWriter(inputF, false, encoding);

            using (streamWriter)
            {
                for (int i = 0; i < str.Count; i++)
                {
                    streamWriter.WriteLine(str[i]);
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

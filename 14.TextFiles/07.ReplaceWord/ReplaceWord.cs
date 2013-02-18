using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


class ReplaceWord
{
    static void Main()
    {
        string folder = "../../";
        string firstF = "test.txt";
        string secondF = "write.txt";

        string inputF = folder + firstF;
        string inputW = folder + secondF;


        System.Text.Encoding encoding = System.Text.Encoding.GetEncoding(1251);


        try
        {
            StreamReader streamReader = new StreamReader(inputF, encoding);
            StreamWriter streamWriter = new StreamWriter(inputW, false, encoding);
            using (streamReader)
            {
                using (streamWriter)
                {
                    string line = streamReader.ReadLine();
                    while (line != null)
                    {
                        streamWriter.WriteLine(line.Replace("start", "finish"));
                        line = streamReader.ReadLine();
                    }
                }
            }

        }
        catch (FileNotFoundException)
        {
            Console.Error.WriteLine("Can't find file {0} or {1}.", firstF, secondF);
        }
        catch (IOException)
        {
            Console.Error.WriteLine("Can't read the file {0} or {1}.", firstF, secondF);
        }
    }
}

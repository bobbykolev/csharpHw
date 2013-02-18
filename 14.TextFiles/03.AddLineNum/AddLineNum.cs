using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class AddLineNum
{
    static void Main()
    {
        string folder = "../../";
        string file = "test.txt";
        string fileW = "write.txt";

        string inputF = folder + file;
        string inputW = folder + fileW;


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
                    int counter = 0;
                    while (line != null)
                    {
                        counter++;
                        streamWriter.WriteLine("{0:00}. {1}", counter, line);
                        line = streamReader.ReadLine();
                    }

                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.Error.WriteLine("Can't find file {0} ", file);
        }
        catch (IOException)
        {
            Console.Error.WriteLine("Can't read the file {0} .", file);
        }
    }
}

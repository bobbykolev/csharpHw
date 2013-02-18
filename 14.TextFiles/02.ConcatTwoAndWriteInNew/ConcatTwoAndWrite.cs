using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class ConcatTwoAndWrite
{
    static void Main()
    {
        string folder = "../../";
        string firstF = "test.txt";
        string secondF = "test2.txt";
        string thirdF = "write.txt";

        string inputFF = folder + firstF;
        string inputSF = folder + secondF;
        string inputTF = folder + thirdF;


        System.Text.Encoding encoding = System.Text.Encoding.GetEncoding(1251);


        try
        {
            StreamReader streamReader = new StreamReader(inputFF, encoding);
            StreamWriter streamWriter = new StreamWriter(inputTF, false, encoding);
            using (streamReader)
            {
                using (streamWriter)
                {
                    string line = streamReader.ReadLine();
                    while (line != null)
                    {
                        streamWriter.WriteLine(line);
                        line = streamReader.ReadLine();
                    }

                }
            }
            streamReader = new StreamReader(inputSF, encoding);
            streamWriter = new StreamWriter(inputTF, true, encoding);

            using (streamReader)
            {
                using (streamWriter)
                {
                    string line = streamReader.ReadLine();
                    while (line != null)
                    {
                        streamWriter.WriteLine(line);
                        line = streamReader.ReadLine();
                    }
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.Error.WriteLine("Can't find file {0} or {1} or {2}.", firstF, secondF, thirdF);
        }
        catch (IOException)
        {
            Console.Error.WriteLine("Can't read the file {0} or {1} or {2}.", firstF, secondF, thirdF);
        }
    }
}

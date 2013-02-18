using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class RemWordsFromOneInOnother
{
    static void Main(string[] args)
    {
        string folder = "../../";
        string firstF = "words.txt";
        string secondF = "test.txt";
        string thirdF = "write.txt";

        string inputF = folder + firstF;
        string inputW = folder + secondF;
        string inputWr = folder + thirdF;


        System.Text.Encoding encoding = System.Text.Encoding.GetEncoding(1251);

        try
        {
            StreamReader streamReaderW = new StreamReader(inputF, encoding);
            List<string> exList = new List<string>();
            using (streamReaderW)
            {

                string line = streamReaderW.ReadLine();
                while (line != null)
                {
                    string[] str = line.Split(new char[] { '.', ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < str.Length; i++)
                    {
                        exList.Add(str[i]);
                    }
                    line = streamReaderW.ReadLine();
                }

            }
            StreamReader streamReaderT = new StreamReader(inputW, encoding);
            StreamWriter streamWriter = new StreamWriter(inputWr, false, encoding);
            string helper = "";
            using (streamReaderT)
            {
                using (streamWriter)
                {
                    string line = streamReaderT.ReadLine();
                    while (line != null)
                    {
                        foreach (var item in exList)
                        {
                            helper = line.Replace(item, "");
                            line = helper;
                        }
                        streamWriter.WriteLine(line);
                        line = streamReaderT.ReadLine();
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

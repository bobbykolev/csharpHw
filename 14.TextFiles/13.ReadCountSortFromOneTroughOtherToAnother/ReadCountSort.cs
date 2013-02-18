using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class ReadCountSort
{

    static void Main()
    {
        string folder = "../../";
        string firstF = "words.txt";
        string secondF = "test.txt";
        string thirdF = "result.txt";

        string inputF = folder + firstF;
        string inputW = folder + secondF;
        string inputWr = folder + thirdF;

        System.Text.Encoding encoding = System.Text.Encoding.GetEncoding(1251);

        try
        {
            StreamReader streamReaderW = new StreamReader(inputF, encoding);
            List<string> exList = new List<string>();
            using (streamReaderW) //here we read the words.txt file and make list(exList) of the words
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
            List<int> ind = new List<int>();
            int counter = 0;
            StreamReader streamReader = new StreamReader(inputW, encoding);
            StreamWriter streamWriter = new StreamWriter(inputWr, false, encoding);
            using (streamReader) //here we read the test file count whith IndexOf the occurrences of every word and we put it the count to List (ind)
            {                    //if theres no occurrence we romove the word from "exList" and we don't add count to "ind". After that we convert the lists
                using (streamWriter) // to arrays and sort the string array by the int array (key) and write the result.
                {
                    string line = streamReader.ReadToEnd();

                    for (int i = 0; i < exList.Count; i++)
                    {
                        int index = line.IndexOf(exList[i]);
                        if (index == -1)
                        {
                            exList.Remove(exList[i]);
                        }
                        while (index != -1)
                        {
                            counter++;

                            index = line.IndexOf(exList[i], index + 1);
                        }
                        if (counter != 0)
                        {
                            ind.Add(counter);
                        } counter = 0;

                    }

                    string[] arrW = exList.ToArray();
                    int[] arrOc = ind.ToArray();

                    Array.Sort(arrOc, arrW);

                    for (int i = arrW.Length - 1; i >= 0; i--)
                    {
                        streamWriter.WriteLine(arrW[i] + " " + arrOc[i]);
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

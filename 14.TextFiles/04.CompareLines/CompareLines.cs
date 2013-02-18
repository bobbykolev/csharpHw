using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

    class CompareLines
    {
       
    static void Main()
    {
        string folder = "../../";
        string firstF = "test.txt";
        string secondF = "test2.txt";
       

        string inputFF = folder + firstF;
        string inputSF = folder + secondF;
        


        System.Text.Encoding encoding = System.Text.Encoding.GetEncoding(1251);


        try
        {
            StreamReader streamReader1 = new StreamReader(inputFF, encoding);
            StreamReader streamReader2 = new StreamReader(inputSF, encoding);
           
                string line1 = streamReader1.ReadLine();
                string line2 = streamReader2.ReadLine();

                int same = 0;
                int diff = 0;
                while (line1 != null)
                    {
                        if (line1==line2)
                        {
                            same++;
                        }
                        else
                        {
                            diff++;
                        }
                        line1 = streamReader1.ReadLine();
                        line2 = streamReader2.ReadLine();
                    }
                    streamReader1.Close();
                    streamReader2.Close();
                    Console.WriteLine("The same lines in '{0}' and '{1}' are {2}.", firstF, secondF, same);
                    Console.WriteLine("The different lines in '{0}' and '{1}' are {2}.", firstF, secondF, diff);

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

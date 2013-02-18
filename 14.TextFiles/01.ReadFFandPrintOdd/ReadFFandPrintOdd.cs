using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class ReadFFandPrintOdd
    {
        static void Main()
        {
            string folder ="../../";
            string file = "test.txt";
            string inputF = folder+file;
            System.Text.Encoding encoding = System.Text.Encoding.GetEncoding(1251);
            
           
            try
            {
                StreamReader streamReader = new StreamReader(inputF, encoding);
                using (streamReader)
                {
                    int counter = 0;
                    string line = streamReader.ReadLine(); 
                    while (line != null)
                    {
                        counter++;
                        if ((counter&1)==1)
                        {
                            Console.WriteLine(line);
                        }
                        line = streamReader.ReadLine();
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.Error.WriteLine("Can't find file {0}.", file);
            }
            catch (IOException)
            {
                Console.Error.WriteLine("Can't read the file {0}.", file);
            }
        }
    }

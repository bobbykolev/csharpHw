using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReadTxtAndHandleAllEx
{
    static void Main()
    {
        string fileName = @"C:\WINDOWS\win.ini";
        
        try
        {
            StreamReader reader = new StreamReader(fileName);

            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    line = reader.ReadLine();
                    Console.WriteLine(line);
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.Error.WriteLine(
                  "Can not find file {0}.", fileName);
        }
        catch (IOException)
        {
            Console.Error.WriteLine(
                  "Can not read the file {0}.", fileName);
        }
    }
}

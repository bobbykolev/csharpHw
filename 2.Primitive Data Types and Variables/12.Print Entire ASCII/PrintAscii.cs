using System;
using System.Text;



    class PrintAscii
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("\t\tThe first 32 characters in the ASCII-table are unprintable control codes and are used to control peripherals such as printers.");
            Console.WriteLine("");
            Console.WriteLine("\t\tCodes32-127 are common for all the different variations of the ASCII table, they are called printable characters, represent letters, digits, punctuation marks, and a few miscellaneous symbols. You will find almost every character on your keyboard. Character 127 represents the command DEL.");
            Console.WriteLine();
            Console.WriteLine("DEC | SYMBOL");

            for (int i = 33; i < 257; i++)
            {
                             
                Console.WriteLine("{0}\t{1}",i,(char)i);
                if (i == 127)
	            {
                    Console.WriteLine("\t\tThere are several different variations of the 8-bit ASCII table. Codes 129-159 contain the Microsoft® Windows Latin-1 extended characters (ISO 8859-1, also called ISO Latin-1).");
                    continue;
	            }
                   

            }
        }
    }


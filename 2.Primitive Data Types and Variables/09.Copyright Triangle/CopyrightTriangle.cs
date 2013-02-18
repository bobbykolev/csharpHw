using System;
using System.Text;

    class CopyrightTriangle
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            char copyright = '\xa9';
            Console.WriteLine("{0,4}\n\r{0,3}{0,2}\n\r{0,2}{0,4}\n\r{0,1}{0,2}{0,2}{0,2}", copyright);
        }
    }


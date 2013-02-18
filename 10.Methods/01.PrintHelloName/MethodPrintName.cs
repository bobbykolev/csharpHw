using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class MethodPrintName
    {
        static void Main()
        {
            PrintHelloName();
        }
        static void PrintHelloName()
        {
            Console.WriteLine("Enter Your name, please:");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", name);
        }
    }

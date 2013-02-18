using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class ConverNtoText
    {
        static void Units(int lastDigit)
        {
            List<string> listUnits = new List<string>() { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            Console.Write("{0} ", listUnits[lastDigit]);
        }
        static void Tens(int middleDigit)
        {
            List<string> listTens = new List<string>() {"", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety"};
            Console.Write("{0} ", listTens[middleDigit - 1]);
        }
        static void Teens(int teenGroup)
        {
            List<string> listTeens = new List<string>() { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            Console.Write("{0} ", listTeens[teenGroup - 10]);
        }
        static void Main()
        {
            Console.WriteLine("Type a number (0 - 999) and press ENTER:");
            int input = int.Parse(Console.ReadLine());

            int lastDigit = input % 10;
            int middleDigit = (input / 10) % 10;
            int firstDigit = (input / 100) % 100;
            int teenGroup = input - (firstDigit * 100);
            if (firstDigit == 0)
            {
                if (middleDigit == 0 && lastDigit == 0)
                {
                    Console.Write("zero");
                }

                if (middleDigit == 0 && lastDigit != 0)
                {
                    Units(lastDigit);
                }

                if (middleDigit > 1)
                {
                    Tens(middleDigit);
                    Units(lastDigit);
                }
                if (teenGroup > 9 && teenGroup <20 )
                {
                    Teens(teenGroup);
                }
            }
            if (firstDigit > 0)
            {
                if (middleDigit > 1)
                {
                    Units(firstDigit);
                Console.Write("hundred ");
                Tens(middleDigit);
                Units(lastDigit);
                }
                if (middleDigit == 0 && lastDigit == 0)
                {
                    Units(firstDigit);
                    Console.Write("hundred");
                }
                if (middleDigit == 0 && lastDigit != 0)
                {
                Units(firstDigit);
                Console.Write("hundred and ");
                Units(lastDigit);
                }
                if (teenGroup > 9 && teenGroup < 20)
                {
                    Units(firstDigit);
                    Console.Write("hundred and ");
                    Teens(teenGroup);
                }
            }

            Console.WriteLine();
        }
    }

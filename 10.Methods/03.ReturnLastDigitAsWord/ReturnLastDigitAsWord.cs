using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class ReturnLastDigitAsWord
    {
        static void Main()
        {
            Console.WriteLine("Enter the integer");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}", LastDigitAsText(n));

        }
        static string LastDigitAsText(int n)
        {
            if (n>9)
            {
                n = n % 10;
            }
            
            string numAsWord;
            switch (n)
            {
            case 1:
                  numAsWord = "one";
                  break;
            case 2:
                  numAsWord = "two";
                  break;
            case 3:
                  numAsWord = "three";
                  break;
            case 4:
                  numAsWord = "four";
                  break;
            case 5:
                  numAsWord = "five";
                  break;
            case 6:
                  numAsWord = "six";
                  break;
            case 7:
                  numAsWord = "seven";
                  break;
            case 8:
                  numAsWord = "eight";
                  break;
            case 9:
                  numAsWord = "nine";
                  break;
            case 0:
                  numAsWord = "zero";
                  break;
            case 11:
                  numAsWord = "November";
                  break;
            case 12:
                  numAsWord = "December";
                  break;
            default:
                  numAsWord = "zero";
                  break;
            }
            return numAsWord;
      
        }
    }

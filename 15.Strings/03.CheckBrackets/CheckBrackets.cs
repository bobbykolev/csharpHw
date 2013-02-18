using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class CheckBrackets
    {
        static void Main()
        {
            string eq = "(3+4)+4)(/(2)";

            int opening = 0;
            int closing = 0;
            if ((eq.IndexOf(')') < eq.IndexOf('(')) || eq[eq.Length-1]=='(')
            {
                Console.WriteLine("Incorrect!");
            }
            else 
            {
                for (int i = 0; i < eq.Length; i++)
                {
                    if (eq[i]=='(')
                    {
                        opening++;
                    }
                    else if (eq[i]==')')
                    {
                        closing++;
                    }
                    if (closing>opening)
                    {
                        break;
                    }
                }
                if (opening==closing)
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine("Incorrect!");
                }
            }
        }
    }

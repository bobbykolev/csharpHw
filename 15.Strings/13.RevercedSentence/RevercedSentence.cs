using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class RevercedSentence
    {
        static void Main()
        {
            string text = "C# is not C++, not PHP and not Delphi!";
            char end = text[text.Length - 1];

            string[] arr = text.Split(new char[] { ' ', '.', '!', '?'});
            

            for (int i = arr.Length-1; i >= 0; i--)
            {
                Console.Write(arr[i]);
                if (i>0 && i<arr.Length-1)
                {
                    Console.Write(" ");
                }
            } Console.WriteLine(end);
        }
    }

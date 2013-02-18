using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class CountEveryLetter
    {
        static void Main()
        {
            string text = @"Lorizzle ipsum dolizzle sizzle shizznit, consectetuer crunk elizzle. 
                            Nullam sapien i saw beyonces tizzles and my pizzle went crizzle, 
                            things volutpizzle, dizzle hizzle, gravida vel, arcu.";
            text = text.ToLower();
            char[] letters = new char[26];
            for (int i = 0; i < letters.Length; i++)
            {
                letters[i]=(char)( 97+i);
            }
            int[] count = new int[26];

            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < letters.Length; j++)
                {
                    if (text[i]==letters[j])
                    {
                        count[j]++;
                    }
                }
            }

            for (int k = 0; k < letters.Length; k++)
            {
                Console.WriteLine("{0} = {1,3} times",letters[k], count[k]);
            }
        }
    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class RemoveEmptySpAndSort
    {
        static void Main()
        {
            string text = @"Lorizzle ipsum dolizzle sizzle shizznit, consectetuer crunk elizzle. 
                            Nullam sapien i saw beyonces tizzles and my pizzle went crizzle, 
                            things volutpizzle, dizzle hizzle, gravida vel, arcu.";

            string[] words = text.Split(new char[] { ' ', ',', '.', '-', '!', '?', ':', ';', '(', ')', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            List<string> listW = words.ToList();
            listW.Sort();
            foreach (var item in listW)
            {
                Console.WriteLine(item);
            }
        }
    }

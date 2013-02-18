using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Print10Random100_200
    {
        static void Main()
        {
            Random rand = new Random();
            for (int number = 1; number <= 10; number++)
            {
                int randomNumber = rand.Next(100,201);
                Console.Write("{0} ", randomNumber);
            }
        }
    }

using System;



    class StringToObjectToString
    {
        static void Main()
        {
            string firstS = "Hello";
            string secondS = "World";

            object firstSAndSecondS = (firstS+" "+secondS);
            Console.WriteLine(firstSAndSecondS);

            string thirdS = (string)firstSAndSecondS;
            Console.WriteLine(thirdS);

        }
    }


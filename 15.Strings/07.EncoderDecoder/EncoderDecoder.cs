using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class EncoderDecoder
    {
        static void Main()
        {
            string text = "Lorem ipsizzle dolor shizzlin dizzle amizzle, break it down adipiscing elit."+
                " Shizzlin dizzle gizzle yippiyo, crackalackin volutpizzle, suscipizzle crackalackin, gravida vizzle, yo mamma.";

            string key = "JUVE";
            string encode = text;

            StringBuilder sb = new StringBuilder();

            for (int i = 0, j = 0; (i < text.Length) && (j < key.Length); i++, j++) //encoding
            {
                sb.Append((char)(encode[i] ^ key[j]));
                if (j == key.Length-1)
                {
                    j = 0;
                }
            }
            Console.WriteLine(sb);
            Console.WriteLine();
            sb.Clear();
            for (int k = 0, n=0; k < (text.Length) && (n<key.Length); k++, n++)//decoding
            {
                sb.Append((char)(encode[k] ^ key[n]^key[n]));
                if (n == key.Length-1)
                {
                    n = 0;
                }
            }
            Console.WriteLine(sb.ToString());
            Console.WriteLine();
        }
    }

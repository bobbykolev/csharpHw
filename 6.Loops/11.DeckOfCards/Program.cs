using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        List<string> card = new List<string>() { "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace" };

        for (int j = 1; j < 5; j++)
        {
            switch (j)
            {
                case 1:
                    for (int i = 0; i < 13; i++)
                    {
                        Console.Write(card[i]);
                        Console.WriteLine(" Of Spades");
                    }
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Red;
                    for (int i = 0; i < 13; i++)
                    {
                        Console.Write(card[i]);
                        Console.WriteLine(" Of Hearts");
                    }
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Red;
                    for (int i = 0; i < 13; i++)
                    {
                        Console.Write(card[i]);
                        Console.WriteLine(" Of Diamonds");
                    }
                    Console.ResetColor();
                    break;
                case 4:
                    for (int i = 0; i < 13; i++)
                    {
                        Console.Write(card[i]);
                        Console.WriteLine(" Of Clubs");
                    }
                    break;
                default:
                    break;
            }
            Console.WriteLine();
        }
    }
}

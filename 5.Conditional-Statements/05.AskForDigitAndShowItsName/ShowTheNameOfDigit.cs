using System;

    class ShowTheNameOfDigit
    {
        static void Main()
        {
            Console.WriteLine("Type a digit (1-9) and press ENTER:");
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1: Console.WriteLine("You've just typed \"One\"");
                    break;
                case 2: Console.WriteLine("You've just typed \"Two\"");
                    break;
                case 3: Console.WriteLine("You've just typed \"Three\"");
                    break;
                case 4: Console.WriteLine("You've just typed \"Four\"");
                    break;
                case 5: Console.WriteLine("You've just typed \"Five\"");
                    break;
                case 6: Console.WriteLine("You've just typed \"Six\"");
                    break;
                case 7: Console.WriteLine("You've just typed \"Seven\"");
                    break;
                case 8: Console.WriteLine("You've just typed \"Eight\"");
                    break;
                case 9: Console.WriteLine("You've just typed \"Nine\"");
                    break;
                default:
                    Console.WriteLine("Try again");
                    break;
            }
        }
    }

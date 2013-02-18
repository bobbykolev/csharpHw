using System;

class PrintFirsNnumbOfFibonacci
{
    static void Main()
    {
        ulong firstNumber = 0;
        ulong secondNumbr = 1;
        ulong thirdNumber = firstNumber + secondNumbr;
        ulong sum = firstNumber+secondNumbr+thirdNumber;
        Console.WriteLine("Type how many numbers from the Fibonacci Seq you want to sum (starting from 0 at first position) ");
        int N = int.Parse(Console.ReadLine());

        if (N == 1)
        {
            Console.WriteLine("Sum of the first member of the Fibonacci Seq = {0}", N-1);
        }
        if (N == 2)
        {
            Console.WriteLine("Sum of the first {0} members of the Fibonacci Seq = {1}", N, N - 1);
        }
        if (N == 3)
        {
            Console.WriteLine("Sum of the first {0} members of the Fibonacci Seq = {1}", N, N - 1);
        }
        if(N > 3)
        {
            for (int i = 1; i <= N - 3; i++)
            {
                firstNumber = secondNumbr;
                secondNumbr = thirdNumber;
                thirdNumber = firstNumber + secondNumbr;
                sum = sum + thirdNumber;
            }
            Console.WriteLine("Sum of the first {0} members of the Fibonacci Seq = {1}", N, sum);
        }
        
    }
}



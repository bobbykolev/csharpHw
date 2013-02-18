using System;

class FindSumS
{
    static void Main()
    {
        int[] arr = { 4, 3, 1, 4, 2, 5, 8 ,5 , 6, 0 };
        int sum = 11;
        int tSum = 0;
        int n;

        for (int i = 0; i < arr.Length-1; i++)
        {
            tSum = arr[i];
            for (int j = i; j < arr.Length-1; j++)
            {
                tSum += arr[j+1];
                if (tSum>sum)
                {
                    break;
                }
                if (tSum==sum)
                {
                    n = j+1-i;
                    Console.Write("{");
                    for (int k = 0; k <= n; k++)
                    {
                        Console.Write(arr[i+k]);
                        if (k<n)
                        {
                            Console.Write(", ");
                        }
                    } 
                    Console.Write("}");
                    Console.WriteLine();
                }
            }
        }
    }
}

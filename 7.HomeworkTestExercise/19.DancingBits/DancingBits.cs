using System;

class DancingBits
{
    static void Main()
    {
        int K = int.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());
        string str = "";
        string helperStr1 = "0";
        string helperStr0 = "1";
        int sum1 = 0;
        int sum0 = 0;

        int[] arr = new int[N];
        for (int i = 0; i < N; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        for (int j = 0; j < N; j++)
        {
            str += Convert.ToString(arr[j], 2);
        }
        for (int n = 0; n < K; n++)
        {
            helperStr1 += "1";
            helperStr0 += "0";
        }
        helperStr1 += "0";
        helperStr0 += "1";

        int index1 = str.IndexOf(helperStr1);
        int index0 = str.IndexOf(helperStr0);

        while (index0 != -1)
        {
            sum0++;
            index0 = str.IndexOf(helperStr0, index0 + 1);
        }

        while (index1 != -1)
        {
            sum1++;
            index1 = str.IndexOf(helperStr1, index1 + 1);
        }

        int result = sum1 + sum0;
        Console.WriteLine(result);
    }
}
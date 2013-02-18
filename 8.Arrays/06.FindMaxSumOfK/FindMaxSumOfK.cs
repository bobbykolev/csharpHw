using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class FindMaxSumOfK
    {
        static void Main()
        {
            Console.WriteLine("Enter the number N");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number K");
            int K = int.Parse(Console.ReadLine());
            int[] arr = new int[N];

            int sum = 0;
            Console.WriteLine("Enter the elements of the array ({0}, separated by enters)", N);
            for (int i = 0; i < N; i++)
            {
                arr[i] = int.Parse(Console.ReadLine()); 
            }

            Array.Sort(arr);
            for (int j = N-1; j > N-K-1; j--)
            {
                sum += arr[j];
            }
            Console.WriteLine("The maximum sum of {0} elements in the array is: {1}", K, sum);
        }
    }

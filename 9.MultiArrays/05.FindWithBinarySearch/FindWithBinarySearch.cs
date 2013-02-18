using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class FindWithBinarySearch
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
           
            for (int i = n-1; i >= 0; i--)
			{
			 if (arr[i]>=k)
	            {
		             arr[i]=int.MinValue;
	            }
			}
            Array.Sort(arr);
            Console.WriteLine(arr[Array.BinarySearch(arr, arr.Max())]); 
        }
    }

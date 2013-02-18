using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class ReadAndCompare
    {
        static void Main()
        {
            Console.WriteLine("Chose the size of the arrays (1-2000000000):");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Fill the {0} elements of the first array (separated by enters):", n);
            object[] obj1 = new object[n];
            object[] obj2 = new object[n];

            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                obj1[i] = Console.ReadLine();
            }
            Console.WriteLine("Fill the {0} elements of the second array (separated by enters):", n);
            for (int j = 0; j < n; j++)
            {
                obj2[j] = Console.ReadLine();
            }
            for (int k = 0; k < n; k++)
            {
                if (obj1[k].Equals(obj2[k]))
                {
                    sum += 1;
                }
                Console.WriteLine("The elements with index {0} of the arrays are equal - {1}", k, obj1[k].Equals(obj2[k]));
            } if (sum == n)
            {
                Console.WriteLine("All elements of the first array are equal to the corresponding elements in second array.");
            }
        }
    }

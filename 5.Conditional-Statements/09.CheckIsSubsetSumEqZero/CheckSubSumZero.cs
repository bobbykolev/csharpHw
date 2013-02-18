using System;
using System.Threading;
using System.Linq;
using System.Collections.Generic;

class CheckSubSumZero
{
    static void Main()
    {


        int sum = 0;

        List<int> ListOf5 = new List<int>();
        for (int i = 0; i < 5; i++)
        {
            int n = int.Parse(Console.ReadLine());
            ListOf5.Add(n);
        }
        if (ListOf5.Sum() == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", ListOf5[0], ListOf5[1], ListOf5[2], ListOf5[3], ListOf5[4]);
        }

        for (int i = 0; i < 4; i++)
        {
            for (int j = i + 1; j < 5; j++)
            {
                if (ListOf5[i] + ListOf5[j] == sum)
                {
                    Console.WriteLine("{0} + {1} = 0", ListOf5[i], ListOf5[j]);
                }

                for (int k = j + 1; k < 5; k++)
                {
                    if (ListOf5[i] + ListOf5[j] + ListOf5[k] == 0)
                    {
                        Console.WriteLine("{0} + {1} + {2} = 0", ListOf5[i], ListOf5[j], ListOf5[k]);
                    }
                    
                        for (int m = k + 1; m < 4; m++)
                        {
                            if (ListOf5[i] + ListOf5[j] + ListOf5[k] + ListOf5[m] == 0)
                            {
                                Console.WriteLine("{0} + {1} + {2} + {3} = 0", ListOf5[i], ListOf5[j], ListOf5[k], ListOf5[m]);
                            }
                        }
                }
            }
        }
    }
}
       
    



        
    
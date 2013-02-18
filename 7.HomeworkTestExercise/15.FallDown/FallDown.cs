using System;
using System.Linq;

class FallDown
{
    static void Main(string[] args)
    {
        int[,] grid = new int[8, 8];
        int maxLine = 0;
        int counter = 0;
        int lineCount = 0;

        for (int rows = 0; rows < 8; rows++)
        {
            int N = int.Parse(Console.ReadLine());

            char[] charArray = Convert.ToString(N, 2).ToCharArray();
            int columns = charArray.Length - 1;
            foreach (char bits in charArray)
            {
                //Console.Write(bits-'0');
                grid[rows, columns] = bits - '0';
                columns--;
            }
        }

        //for (int i = 0; i < 8; i++)
        //{
        //    for (int j = 7; j >= 0; j--)
        //    {
        //        Console.Write(grid[i, j]);
        //    }
        //    Console.WriteLine();
        //}

        for (int cols = 0; cols < 8; cols++)
        {
            for (int rows = 6; rows >= 0; rows--)
            {
                int remember = rows;
                for (int fall = rows + 1; fall < 8; fall++)
                {
                    if (grid[fall, cols] == 0)
                    {
                        grid[fall, cols] = grid[rows, cols];
                        grid[rows, cols] = 0;
                        rows = fall;
                    }
                }
                rows = remember;
            }
        }
        //for (int i = 0; i < 8; i++)
        //{
        //    for (int j = 7; j >= 0; j--)
        //    {
        //        Console.Write(grid[i, j]);
        //    }
        //    Console.WriteLine();
        //}

        for (int k = 0; k < 8; k++)
        {
            string strTest = "";
            for (int j = 7; j >= 0; j--)
            {
                strTest += grid[k, j];
            }
            Console.WriteLine(Convert.ToInt32(strTest, 2));
        }
    }
}
using System;

class Lines
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

        for (int rows = 0; rows < 8; rows++)
        {
            counter = 0;
            for (int cols = 0; cols < 8; cols++)
            {
                if (grid[rows, cols] == 1)
                {
                    counter++;

                    if (grid[rows, cols + 1 < 8 ? cols + 1 : cols] == 0)
                    {
                        if (counter > maxLine)
                        {
                            maxLine = counter;
                            lineCount = 1;
                            counter = 0;
                        }
                        else if (counter == maxLine)
                        {
                            lineCount++;
                            counter = 0;
                        }
                        counter = 0;
                    }
                    else if (cols == 7)
                    {

                        if (counter > maxLine)
                        {
                            maxLine = counter;
                            lineCount = 1;
                            counter = 0;
                        }
                        else if (counter == maxLine)
                        {
                            lineCount++;
                            counter = 0;
                        }
                    }

                }
            }
        }

        for (int cols = 0; cols < 8; cols++)
        {
            counter = 0;
            for (int rows = 0; rows < 8; rows++)
            {
                if (grid[rows, cols] == 1)
                {
                    counter++;

                    if (grid[rows + 1 < 8 ? rows + 1 : rows, cols] == 0)
                    {

                        if (counter > maxLine)
                        {
                            maxLine = counter;
                            lineCount = 1;
                            counter = 0;
                        }
                        else if (counter == maxLine)
                        {
                            lineCount++;
                            counter = 0;
                        }
                        counter = 0;
                    }
                    else if (rows == 7)
                    {

                        if (counter > maxLine)
                        {
                            maxLine = counter;
                            lineCount = 1;
                            counter = 0;
                        }
                        else if (counter == maxLine)
                        {
                            lineCount++;
                            counter = 0;
                        }
                    }

                }
            }
        }
        if (maxLine == 1)
        {
            lineCount /= 2;
        }
        Console.WriteLine(maxLine);
        Console.WriteLine(lineCount);

    }
}
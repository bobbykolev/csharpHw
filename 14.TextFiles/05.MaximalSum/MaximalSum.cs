using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class MaximalSum
{
    public static int ReturnMaxSum(int[,] arr)
    {
        int bestSum = int.MinValue;

        for (int row = 0; row < arr.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < arr.GetLength(1) - 1; col++)
            {
                int sum = arr[row, col] + arr[row, col + 1] +
                      arr[row + 1, col] + arr[row + 1, col + 1];
                if (sum > bestSum)
                {
                    bestSum = sum;
                }
            }
        }

        return bestSum;
    }
    static void Main()
    {
        string folder = "../../";
        string firstF = "test.txt";
        string secondF = "write.txt";

        string inputF = folder + firstF;
        string inputW = folder + secondF;

        System.Text.Encoding encoding = System.Text.Encoding.GetEncoding(1251);

        try
        {
            StreamReader streamReaderW = new StreamReader(inputF, encoding);
            StreamWriter streamWriter = new StreamWriter(inputW, false, encoding);
            using (streamReaderW)
            {

                string line = streamReaderW.ReadLine();
                int n = int.Parse(line);
                int[,] arr = new int[n, n];
                int count = 0;
                line = streamReaderW.ReadLine();
                while (line != null)
                {

                    string[] str = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    for (int i = 0; i < n; i++)
                    {
                        arr[count, i] = int.Parse(str[i]);
                    }
                    count++;
                    line = streamReaderW.ReadLine();
                }
                using (streamWriter)
                {
                    streamWriter.WriteLine(ReturnMaxSum(arr));
                }

            }






        }
        catch (FileNotFoundException)
        {
            Console.Error.WriteLine("Can't find file {0} or {1}.", firstF, secondF);
        }
        catch (IOException)
        {
            Console.Error.WriteLine("Can't read the file {0} or {1}.", firstF, secondF);
        }

    }
}

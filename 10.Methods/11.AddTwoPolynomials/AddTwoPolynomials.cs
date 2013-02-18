using System;


class AddTwoPolynomials
{
    static void Main()
    {
        //arrays with reversed coefficients
        decimal[] firstArr = { -1m, 0m, 5m }; //5x^2-1
        decimal[] secArr = { 3.5m, 0m, 2m, 9m, 0m, 5m }; //5x^5+9x^3+2x^2+3.5

        AddPolys(firstArr, secArr);
    }

    static void AddPolys(decimal[] firstArr, decimal[] secArr)
    {
        int a = firstArr.Length;
        int b = secArr.Length;
        int longestArrL = Math.Max(a, b);

        decimal[] sumArr = new decimal[longestArrL];


        for (int i = longestArrL - 1; i >= 0; i--)
        {
            //adding from last element of the first + last of the second and checks for the shorter one
            sumArr[i] = (firstArr.Length - 1 < i ? 0 : firstArr[i]) + (secArr.Length < i ? 0 : secArr[i]);

            //printing the result (excluding the zeros)
            if (sumArr[i] != 0)
            {
                Console.Write("{0}", sumArr[i]);
                if (i != 0)
                {
                    Console.Write("x^{0}", i);
                    Console.Write("+");
                }
            }
        } Console.WriteLine();
    }
}


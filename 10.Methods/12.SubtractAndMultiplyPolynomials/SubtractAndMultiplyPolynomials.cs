using System;


class AddTwoPolynomials
{
    static void Main()
    {
        //arrays with reversed coefficients
        decimal[] firstArr = { -1m, 0m, 5m }; //5x^2-1
        decimal[] secArr = { 3.5m, 0m, 2m, 9m, 0m, 5m }; //5x^5+9x^3+2x^2+3.5

        SubtractPolys(firstArr, secArr);
        MultiplyPolys(firstArr, secArr);
    }

    static void SubtractPolys(decimal[] firstArr, decimal[] secArr)
    {
        int a = firstArr.Length;
        int b = secArr.Length;
        int longestArrL = Math.Max(a, b);

        decimal[] sumArr = new decimal[longestArrL];


        for (int i = longestArrL - 1; i >= 0; i--)
        {
            //adding from last element of the first + last of the second and checks for the shorter one
            sumArr[i] = (firstArr.Length - 1 < i ? 0 : firstArr[i]) - (secArr.Length < i ? 0 : secArr[i]);

            //printing the result (excluding the zeros)

            if (sumArr[i] != 0)
            {
                if ((sumArr[i] > 0) && (i < firstArr.Length))
                {
                    Console.Write("+");
                }
                Console.Write("{0}", sumArr[i]);
                if (i != 0)
                {
                    Console.Write("x^{0}", i);

                }
            }
        } Console.WriteLine();
    }


    static void MultiplyPolys(decimal[] firstArr, decimal[] secArr)
    {
        decimal[] mArr = new decimal[firstArr.Length + secArr.Length - 1];
        for (int i = 0; i < firstArr.Length; i++)
        {
            for (int j = 0; j < secArr.Length; j++)
            {
                mArr[i + j] += firstArr[i] * secArr[j];
            }
        }
        for (int k = mArr.Length-1; k >= 0; k--)
        {
            if (mArr[k]!=0)
            {
                if ((k < mArr.Length-1) && (mArr[k]>0))
                {
                    Console.Write("+");
                }
                Console.Write(mArr[k]);
                if (k!=0)
                {
                    Console.Write("x^" + k);
                }
                
            }
        } Console.WriteLine();
    }
}



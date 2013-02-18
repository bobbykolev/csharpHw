using System;

class Program
{
    static void Main()
        {
            Console.Write("Enter number between 0 and 4 130 000 000: ");
            uint n = uint.Parse(Console.ReadLine());
            uint mask = 7;
            uint maskForBits345 = mask << 3;
            uint bits345 = n & maskForBits345;

            //Console.WriteLine(Convert.ToString(bits345,2));

            uint mask242526 = mask << 24;
            uint bits242526 = n & mask242526;

            //Console.WriteLine(Convert.ToString(bits242526, 2));
            uint newN = (n & ~(maskForBits345)) & ~(mask242526);  

            uint result = (newN | bits345) | bits242526;

            Console.WriteLine(Convert.ToString(result, 2));
                
            
        }
}

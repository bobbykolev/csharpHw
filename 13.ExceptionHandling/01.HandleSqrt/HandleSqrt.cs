using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class HandleSqrt
{
    static void Main()
    {
        try
        {
            uint n = uint.Parse(Console.ReadLine());
            double sqrt = Math.Sqrt(n);
            Console.WriteLine(sqrt); 
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number!");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Invalid number!");
        }
        finally
        {
            Console.WriteLine("Good bye!");
        }
    }
}

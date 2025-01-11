using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int z = Plus(1, 2);
            Console.WriteLine(z);

            int first = 10;
            int second = 2;
            int result = Minus(ref first, ref second);
            Console.WriteLine(result);


        }

        static int Plus(int x, int y)
        {   
            int z = x + y;
            return z;
        }

        static int Minus ( ref int x, ref int y)
        {
            int z = x - y;
            return z;
        }
    }
}

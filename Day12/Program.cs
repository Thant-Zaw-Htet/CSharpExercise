using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12
{
    internal class Program
    {

        static void Main(string[] args)
        {
            double result = Divide(0);
            Console.WriteLine(result);
        }
        
        static double Divide(int val)
        {
            double res = 100 / val;
            return res;
        }
    }

}


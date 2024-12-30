using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computer com = new Computer();
            com.Computer1();
            Computer.Computer2();

            Console.WriteLine(com.Computer3());

            int totalAmount = 100;
            string computer4 = com.Computer4(totalAmount);
         
            Console.WriteLine($"{computer4}");

        }
    }

    class Computer
    {
        public void Computer1()
        {
            Console.WriteLine("Can Computing");
        }

        public static void Computer2()
        {
            Console.WriteLine("Can Calculate");
        }

        public string Computer3()
        {
            string output = "Have AI";
            return output;
        }

        public string Computer4(int amount)
        {
            string output = $"Have Copilot with amount: {amount}";
            return output;
        }
    }
}

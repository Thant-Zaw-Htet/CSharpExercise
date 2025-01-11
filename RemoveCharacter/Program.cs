using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveCharacter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input: ");
            string input = Console.ReadLine();  

            Console.Write("Enter Character: ");
            int chaInput = int.Parse(Console.ReadLine());

            Console.WriteLine(removeCha(input, chaInput));
   
        }

        public static string removeCha (string input, int n)
        {
            return input.Remove(n,1);
        }

 

    }
}

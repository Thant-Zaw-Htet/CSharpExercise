using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuDrivenProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first integer: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second integer: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

           
          
            Console.WriteLine("Here are the options: \n1-Addition \n2-Substraction \n3-Multiplication \n4-Division \n5-Exit");

            int menu = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Input your choice: {menu}");
            switch (menu)
            {
                case 1:
                   int Addresult = num1 + num2;
                   Console.WriteLine($"{num1} + {num2} = {Addresult}");break;
                case 2:
                    int Subresult = num1 - num2;
                    Console.WriteLine($"{num1} - {num2} = {Subresult}");break;
                case 3:
                    int Mulresult = num1 * num2;
                    Console.WriteLine($"{num1} x {num2} = {Mulresult}");break ;
                case 4:
                    int Divresult = num1 / num2;
                    Console.WriteLine($"{num1} / {num2} = {Divresult}");break;
                default: Console.WriteLine("Invalid choice");break;
                    
            }
        }
    }
}
